using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_GUI.Models;
using Moodle_Ofline_Browser_GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using Moodle_Ofline_Browser_Core.models.activities.activityTypes;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Helpers
{
    public class CategoriesCreatorHelper
    {
        private ObservableCollection<ModelCategory> categoryItems;
        private FullCourse fullCourse;
        private Dictionary<string, Moodle_Ofline_Browser_Core.models.users.User> Users;

        public CategoriesCreatorHelper(FullCourse fullCourse)
        {
            FullCourse = fullCourse;
            categoryItems = new ObservableCollection<ModelCategory>();
            Users = new Dictionary<string, Moodle_Ofline_Browser_Core.models.users.User>();
        }

        public ObservableCollection<ModelCategory> CategoryItems
        {
            get
            {
                return categoryItems;
            }
        }

        public FullCourse FullCourse
        {
            set
            {
                fullCourse = value;
            }
        }

        public void LoadToCategories()
        {
            CreateUsersDictionary();
            LoadFiles();
            LoadCourseDetails();
            LoadActivities();
            LoadUsers();
            
            
            
        }

        public void CreateUsersDictionary()
        {
            foreach (Moodle_Ofline_Browser_Core.models.users.User user in fullCourse.Users.User)
            {
                Users.Add(user.Id, user);
            }
        }

        private void LoadCourseDetails()
        {
            ModelCategory course = new ModelCategory();
            course.CategoryName = "Kurs";
            course.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

            
            foreach (System.Reflection.PropertyInfo prop in typeof(Moodle_Ofline_Browser_Core.models.course.Course).GetProperties())
            {
                ModelCategory courseInfo = new NameValuePair();
                courseInfo.CategoryName = prop.Name;
                courseInfo.ParentCategory = course;
                courseInfo.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
                ((NameValuePair)courseInfo).Name = prop.Name;
                if (prop.GetValue(fullCourse.Course.Course, null) is string)
                {
                    ((NameValuePair)courseInfo).Value=(string)prop.GetValue(fullCourse.Course.Course, null);
                }
                else if (prop.GetValue(fullCourse.Course.Course, null) is long)
                {
                    ((NameValuePair)courseInfo).Value = DateTimeOffset.FromUnixTimeSeconds((long)prop.GetValue(fullCourse.Course.Course, null)).ToString("G");
                }
                course.SubCategories.Add(courseInfo);
            }


            categoryItems.Add(course);
        }

        private void LoadFiles()
        {
            ModelCategory files = new ModelCategory();
            files.CategoryName = "Pliki";
            files.FieldInfo = typeof(MainViewModel).GetField("_filesListViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (Moodle_Ofline_Browser_Core.models.files.File file in fullCourse.Files.File)
            {
                string path = "";
                if (fullCourse.FilesFolder.TryGetValue(file.Contenthash, out path))
                {
                    ModelCategory fileSubItem = new File();
                    fileSubItem.ParentCategory = files;
                    fileSubItem.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
                    fileSubItem.CategoryName = file.Filename;
                    ((File)fileSubItem).Id = file.Id;
                    ((File)fileSubItem).FileName = file.Filename;
                    Moodle_Ofline_Browser_Core.models.users.User user;
                    if(Users.TryGetValue(file.Userid,out user))
                        ((File)fileSubItem).User = user.Firstname+" "+ user.Lastname;
                    ((File)fileSubItem).UserId = file.Userid;
                    ((File)fileSubItem).Date = DateTimeOffset.FromUnixTimeSeconds(file.Timecreated).ToString("G");

                    ModelCategory fileDetails=null;

                    foreach (System.Reflection.PropertyInfo prop in typeof(Moodle_Ofline_Browser_Core.models.files.File).GetProperties())
                    {
                        fileDetails = new NameValuePair();
                        fileDetails.ParentCategory = fileSubItem;
                        fileDetails.CategoryName = prop.Name;
                        fileDetails.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

                        ((NameValuePair)fileDetails).Name = prop.Name;

                        if (prop.GetValue(file, null) is string)
                            ((NameValuePair)fileDetails).Value=(string)prop.GetValue(file, null);
                        else if (prop.GetValue(file, null) is long)
                            ((NameValuePair)fileDetails).Value = DateTimeOffset.FromUnixTimeSeconds((long)prop.GetValue(file, null)).ToString("G");
                        fileSubItem.SubCategories.Add(fileDetails);
                    }
                    fileDetails = new NameValuePair();
                    fileDetails.CategoryName = "Path";
                    fileDetails.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
                    ((NameValuePair)fileDetails).Name = "Path";
                    ((NameValuePair)fileDetails).Value = path;
                    fileSubItem.SubCategories.Add(fileDetails);
                    files.SubCategories.Add(fileSubItem);
                }
            }

            categoryItems.Add(files);
        }

        private void LoadActivities()
        {
            ModelCategory activities = new ModelCategory();
            activities.CategoryName = "Aktywności";
            activities.FieldInfo = typeof(MainViewModel).GetField("_activitiesListViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (KeyValuePair<int, Moodle_Ofline_Browser_Core.models.activities.ActivityFolder> activity in fullCourse.ActivitiesFolder)
            {
                if (activity.Value.Activity != null)
                {
                    ModelCategory activitiesSubItem = new Models.Activity();
                    activitiesSubItem.ParentCategory = activities;
                   
                    activitiesSubItem.CategoryName = activity.Value.Activity.Modulename + "_" + activity.Value.Activity.Moduleid;
                    activitiesSubItem.FieldInfo = typeof(MainViewModel).GetField("_activitiesListViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

                    ((Models.Activity)activitiesSubItem).Id= activity.Value.Activity.Moduleid;
                    ((Models.Activity)activitiesSubItem).Type = activity.Value.Activity.Modulename;

                    switch (activity.Value.Activity.Modulename)
                    {
                        case "attendance":
                            ((Models.Activity)activitiesSubItem).Name = 
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance.Attendance)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "assign":
                            ((Models.Activity)activitiesSubItem).Name = 
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign.Assign)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "bigbluebuttonbn":
                            ((Models.Activity)activitiesSubItem).Name = 
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.bigbluebuttonbn.Bigbluebuttonbn)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "book":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.book.Book)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "chat":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.chat.Chat)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "checklist":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.checklist.Checklist)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "choice":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.choice.Choice)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "customcert":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.customcert.Customcert)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "folder":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.folder.Folder)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "forum":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.forum.Forum)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "page":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.page.Page)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "quiz":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.quiz.Quiz)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "survey":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.survey.Survey)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "url":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.url.Url)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        case "wiki":
                            ((Models.Activity)activitiesSubItem).Name =
                                (
                                (Moodle_Ofline_Browser_Core.models.activities.activityTypes.wiki.Wiki)
                                activity.Value.Activity.ActivityType)
                                .Name;
                            break;
                        default:
                            break;
                    }
                    activities.SubCategories.Add(activitiesSubItem);
                }
            }

            categoryItems.Add(activities);
        }

        private void LoadUsers()
        {
            ModelCategory users = new ModelCategory();
            users.CategoryName = "Użytkownicy";
            users.FieldInfo = typeof(MainViewModel).GetField("_usersListViewModel", BindingFlags.Instance | BindingFlags.NonPublic);



            foreach (Moodle_Ofline_Browser_Core.models.users.User user in fullCourse.Users.User)
            {
                ModelCategory usersSubItem = new User();
                usersSubItem.ParentCategory = users;
                usersSubItem.CategoryName = user.Firstname+" "+user.Lastname;
                usersSubItem.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

                ((User)usersSubItem).Id = user.Id;
                ((User)usersSubItem).FirstName = user.Firstname;
                ((User)usersSubItem).Surname = user.Lastname;
                ((User)usersSubItem).Email = user.Email;

                ModelCategory userSubitem;
                ModelCategory userSubSubItem;

                userSubitem = new NameValuePair();
                userSubitem.ParentCategory = usersSubItem;
                ((NameValuePair)userSubitem).Name = "Aktywności użytkownika";
                userSubitem.CategoryName = "Aktywności użytkownika";
                userSubitem.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
                usersSubItem.SubCategories.Add(userSubitem);

                userSubitem = new NameValuePair();
                userSubitem.ParentCategory = usersSubItem;
                ((NameValuePair)userSubitem).Name = "Pliki użytkownika";
                userSubitem.CategoryName = "Pliki użytkownika";
                userSubitem.FieldInfo = typeof(MainViewModel).GetField("_filesListViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
                foreach(File file in CategoryItems[0].SubCategories)
                {
                    if(file.UserId==user.Id)
                    {
                        File _file = new File(file);
                        _file.ParentCategory = userSubitem;
                        userSubitem.SubCategories.Add(_file);
                    }
                }
                usersSubItem.SubCategories.Add(userSubitem);

                userSubitem = new NameValuePair();
                userSubitem.ParentCategory = usersSubItem;
                ((NameValuePair)userSubitem).Name = "Informacje szczegółowe";
                userSubitem.CategoryName = "Informacje szczegółowe";
                userSubitem.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
                foreach (System.Reflection.PropertyInfo prop in typeof(Moodle_Ofline_Browser_Core.models.users.User).GetProperties())
                {
                    userSubSubItem = new NameValuePair();
                    userSubSubItem.ParentCategory= userSubitem;
                    userSubSubItem.CategoryName = prop.Name;
                    userSubSubItem.FieldInfo = typeof(MainViewModel).GetField("_infoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
                    ((NameValuePair)userSubSubItem).Name = prop.Name;
                    if (prop.GetValue(user, null) is string)
                        ((NameValuePair)userSubSubItem).Value = (string)prop.GetValue(user, null);
                    else if (prop.GetValue(user, null) is long)
                        ((NameValuePair)userSubSubItem).Value = DateTimeOffset.FromUnixTimeSeconds((long)prop.GetValue(user, null)).ToString("G");
                    userSubitem.SubCategories.Add(userSubSubItem);
                }
                usersSubItem.SubCategories.Add(userSubitem);



                users.SubCategories.Add(usersSubItem);
            }
            categoryItems.Add(users);
        }
    }
}

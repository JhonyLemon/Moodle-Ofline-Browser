using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_GUI.Models;
using Moodle_Ofline_Browser_GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Helpers
{
    public class CategoriesCreatorHelper
    {
        private ObservableCollection<ModelCategory> categoryItems;
        private FullCourse fullCourse;

        public CategoriesCreatorHelper(FullCourse fullCourse)
        {
            FullCourse = fullCourse;
            categoryItems = new ObservableCollection<ModelCategory>();
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
            LoadUsers();
            LoadActivities();
            LoadFiles();
            LoadCourseDetails();
        }

        private void LoadCourseDetails()
        {
            ModelCategory course = new ModelCategory();
            course.CategoryName = "Kurs";
            course.FieldInfo = typeof(MainViewModel).GetField("_courseDetailedInfoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

            
            foreach (System.Reflection.PropertyInfo prop in typeof(Moodle_Ofline_Browser_Core.models.course.Course).GetProperties())
            {
                ModelCategory courseInfo = new NameValuePair();
                courseInfo.CategoryName = prop.Name;
                courseInfo.FieldInfo = course.FieldInfo;
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

                    fileSubItem.FieldInfo = typeof(MainViewModel).GetField("_fileInfoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
                    fileSubItem.CategoryName = file.Filename;
                    ((File)fileSubItem).Id = file.Id;
                    ((File)fileSubItem).FileName = file.Filename;
                    foreach (Moodle_Ofline_Browser_Core.models.users.User user in fullCourse.Users.User)
                    {
                        if (user.Id == file.Userid)
                        {
                            ((File)fileSubItem).FileName = user.Firstname + " " + user.Lastname;
                            break;
                        }
                    }
                    ((File)fileSubItem).Date = DateTimeOffset.FromUnixTimeSeconds(file.Timecreated).ToString("G");

                    ModelCategory fileDetails=null;

                    foreach (System.Reflection.PropertyInfo prop in typeof(Moodle_Ofline_Browser_Core.models.files.File).GetProperties())
                    {
                        fileDetails = new NameValuePair();

                        fileDetails.CategoryName = prop.Name;
                        fileDetails.FieldInfo = typeof(MainViewModel).GetField("_fileInfoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

                        ((NameValuePair)fileDetails).Name = prop.Name;

                        if (prop.GetValue(file, null) is string)
                            ((NameValuePair)fileDetails).Value=(string)prop.GetValue(file, null);
                        else if (prop.GetValue(file, null) is long)
                            ((NameValuePair)fileDetails).Value = DateTimeOffset.FromUnixTimeSeconds((long)prop.GetValue(file, null)).ToString("G");
                        fileSubItem.SubCategories.Add(fileDetails);
                    }
                    fileDetails = new NameValuePair();
                    fileDetails.CategoryName = "Path";
                    fileDetails.FieldInfo = typeof(MainViewModel).GetField("_fileInfoViewModel", BindingFlags.Instance | BindingFlags.NonPublic);
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
                if (activity.Value.ActivityType != null)
                {
                    ModelCategory activitiesSubItem = new Activity();

                    activitiesSubItem.CategoryName = activity.Value.ActivityType.Modulename + "_" + activity.Value.ActivityType.Id;
                    activitiesSubItem.FieldInfo = typeof(MainViewModel).GetField("_activitiesListViewModel", BindingFlags.Instance | BindingFlags.NonPublic);


                    ((Activity)activitiesSubItem).Id= activity.Value.ActivityType.Id;
                    ((Activity)activitiesSubItem).Type = activity.Value.ActivityType.Modulename;

                    switch (activity.Value.ActivityType.Modulename)
                    {
                        case "attendance":
                            ((Activity)activitiesSubItem).Name = ((Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance.Attendance)activity.Value.ActivityType.ActivityType).Name;
                            break;
                        case "assign":
                            ((Activity)activitiesSubItem).Name = ((Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign.Assign)activity.Value.ActivityType.ActivityType).Name;
                            break;
                        case "chat":
                            break;
                        case "quiz":
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
                users.CategoryName = "Użytkownicy";
                users.FieldInfo = typeof(MainViewModel).GetField("_usersListViewModel", BindingFlags.Instance | BindingFlags.NonPublic);

                ((User)usersSubItem).Id = user.Id;
                ((User)usersSubItem).FirstName = user.Firstname;
                ((User)usersSubItem).Surname = user.Lastname;
                ((User)usersSubItem).Email = user.Email;

                users.SubCategories.Add(usersSubItem);
            }
            categoryItems.Add(users);
        }
    }
}

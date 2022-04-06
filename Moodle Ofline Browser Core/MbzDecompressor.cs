using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpCompress.Readers;
using SharpCompress.Common;
using System.Xml.Serialization;
using Moodle_Ofline_Browser_Core.models;

namespace Moodle_Ofline_Browser_Core
{
    public static class MbzDecompressor
    {
        private static Dictionary<string, TypeAndName> GlobalsTypeMap = new Dictionary<string, TypeAndName>()
        {
            {"badges.xml",new TypeAndName(typeof(models.badges.Badges),"Badges")},
            {"completion.xml",new TypeAndName(typeof(models.completion.Course_completion),"Completion")},
            {"files.xml",new TypeAndName(typeof(models.files.Files),"Files")},
            {"grade_history.xml",new TypeAndName(typeof(models.grade_history.Grade_history),"gradeHistory")},
            {"gradebook.xml",new TypeAndName(typeof(models.gradebook.Gradebook),"Gradebook")},
            {"groups.xml",new TypeAndName(typeof(models.groups.Groups),"Groups")},
            {"moodle_backup.xml",new TypeAndName(typeof(models.moodle_backup.Moodle_backup),"moodleBackup")},
            //{"outcomes.xml",new Pair(typeof(models.outcomes.Outcomes),"Outcomes")},
            {"questions.xml",new TypeAndName(typeof(models.questions.Question_categories),"Questions")},
            {"roles.xml",new TypeAndName(typeof(models.roles.Roles_definition),"Roles")},
            //{"scales.xml",new Pair(typeof(models.scales.Scales),"Scales")},
            {"users.xml",new TypeAndName(typeof(models.users.Users),"Users")}
        };

        private static Dictionary<string, TypeAndName> ActivitiesTypeMap = new Dictionary<string, TypeAndName>()
        {
            {"module.xml",new TypeAndName(typeof(models.module.Module),"Module")},
            {"roles.xml",new TypeAndName(typeof(models.roles.Roles),"Roles")},
            {"logstores.xml",new TypeAndName(typeof(models.logstores.Logstores),"Logstores")},
            //{"logs.xml",new Pair(typeof(models.logs.Logs),"Logs")},
            {"inforef.xml",new TypeAndName(typeof(models.inforef.Inforef),"Inforef")},
            {"grades.xml",new TypeAndName(typeof(models.grades.Activity_gradebook),"activityGradebook")},
            {"grade_history.xml",new TypeAndName(typeof(models.grade_history.Grade_history),"gradeHistory")},
            //{"filters.xml",new Pair(typeof(models.filters.Filters),"Filters")},
            //{"completion.xml",new Pair(typeof(models.completion.Completions),"Completion")},
            //{"competencies.xml",new Pair(typeof(models.competencies.Competencies),"Competencies")},
            //{"comments.xml",new Pair(typeof(models.comments.Comments),"Comments")},
            {"calendar.xml",new TypeAndName(typeof(models.calendar.Events),"Calendar")},

            {"assign.xml",new TypeAndName(typeof(models.activities.activityTypes.Activity),"ActivityType")},
            {"grading.xml",new TypeAndName(typeof(models.grading.Areas),"Grading")},

            {"attendance.xml",new TypeAndName(typeof(models.activities.activityTypes.Activity),"ActivityType")}
        };

        private static Dictionary<string, TypeAndName> CourseTypeMap = new Dictionary<string, TypeAndName>()
        {
            {"logstores.xml",new TypeAndName(typeof(models.logstores.Logstores),"Logstores")},
            //{"logs.xml",new Pair(typeof(models.logs.Logs),"Logs")},
            {"inforef.xml",new TypeAndName(typeof(models.inforef.Inforef),"Inforef")},
            //{"filters.xml",new Pair(typeof(models.filters.Filters),"Filters")},
            //{"competencies.xml",new Pair(typeof(models.competencies.Competencies),"Competencies")},
            //{"comments.xml",new Pair(typeof(models.comments.Comments),"Comments")},
            //{"course.xml",new Pair(typeof(models.course.Course),"Course")},
            //{"contentbank.xml",new Pair(typeof(models.contentbank.Contentbank),"Contentbank")},
            //{"compeltiondefaults.xml",new Pair(typeof(models.completiondefaults.Completiondefaults),"Completiondefaults")},
            {"enrolments.xml",new TypeAndName(typeof(models.enrolments.Enrolments),"Enrolments")},
            {"loglastaccess.xml",new TypeAndName(typeof(models.loglastaccess.Lastaccesses),"LastAccess")},
            {"calendar.xml",new TypeAndName(typeof(models.calendar.Events),"Calendar")}
        };

        private static Dictionary<string, TypeAndName> SectionTypeMap = new Dictionary<string, TypeAndName>()
        {
            {"inforef.xml",new TypeAndName(typeof(models.inforef.Inforef),"Inforef")},
            {"section.xml",new TypeAndName(typeof(models.section.Section),"Section")}
        };

        private static Dictionary<string, TypeAndName> InfoRefTypeMap = new Dictionary<string, TypeAndName>()
        {
            {"course",new TypeAndName(typeof(models.inforef.type.course.Course),"Inforef")},
            {"attendance",new TypeAndName(typeof(models.inforef.type.attendance.Attendance),"Inforef")},
            {"folder",new TypeAndName(typeof(models.inforef.type.folder.Folder),"Inforef")},
            {"quiz",new TypeAndName(typeof(models.inforef.type.quiz.Quiz),"Inforef")},
            {"assign",new TypeAndName(typeof(models.inforef.type.assign.Assign),"Inforef")}
        };

        public static FullCourse Extract(string path)
        {
            FullCourse fullCourse = new FullCourse();
            using (Stream stream = File.OpenRead(path))
            {
                var reader = ReaderFactory.Open(stream);
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                          reader.WriteEntryToDirectory(@"C:\Users\Adam\Downloads\test", new ExtractionOptions { ExtractFullPath = true, Overwrite = true });
                        //if (reader.Entry.Key.Contains("activities/"))
                        //{
                        //    using (EntryStream entry = reader.OpenEntryStream())
                        //    {
                        //        ParseActivities(reader.Entry.Key, entry, fullCourse);
                        //    }
                        //}
                        //else if (reader.Entry.Key.Contains("course/"))
                        //{
                        //    using (EntryStream entry = reader.OpenEntryStream())
                        //    {
                        //        ParseCourse(reader.Entry.Key, entry, fullCourse);
                        //    }
                        //}
                        //else if (reader.Entry.Key.Contains("files/"))
                        //{
                        //    using (EntryStream entry = reader.OpenEntryStream())
                        //    {
                        //        ParseFiles(reader.Entry.Key, entry, fullCourse);
                        //    }
                        //}
                        //else if (reader.Entry.Key.Contains("sections/section_"))
                        //{
                        //    using (EntryStream entry = reader.OpenEntryStream())
                        //    {
                        //        ParseSections(reader.Entry.Key, entry, fullCourse);
                        //    }
                        //}
                        //else
                        //{
                        //    using(EntryStream entry = reader.OpenEntryStream())
                        //    {
                        //        ParseGlobals(reader.Entry.Key, entry,fullCourse);
                        //    }
                        //}
                    }
                }
            }
            return fullCourse;
        }

        private static void ParseActivities(string key, Stream stream, FullCourse fullCourse)
        {
            TypeAndName pair;
            int id = Convert.ToInt32(key.Substring(key.IndexOf('_') + 1, ((key.IndexOf('/', key.IndexOf('_') + 1)) - (key.IndexOf('_') + 1))));
            string name = key.Substring(key.LastIndexOf('/') + 1);
            string activityType = key.Substring((key.IndexOf('/', 1) + 1), (key.IndexOf('_')) - (key.IndexOf('/', 1) + 1));
            models.activities.ActivityFolder activityFolder;
            if (fullCourse.ActivitiesFolder.ContainsKey(id))
            {
                activityFolder = fullCourse.ActivitiesFolder[id];
            }
            else
            {
                activityFolder = new models.activities.ActivityFolder();
                fullCourse.ActivitiesFolder.Add(id, activityFolder);
            }
            if (ActivitiesTypeMap.TryGetValue(name, out pair))
            {
                if (name == "inforef.xml" && !InfoRefTypeMap.TryGetValue(activityType, out pair))
                    return;
                XmlSerializer serializer = new XmlSerializer(pair.Type);
                var test = serializer.Deserialize(stream);
                activityFolder.GetType().GetProperty(pair.propertyName).SetValue(activityFolder, test);
            }
        }
        private static void ParseCourse(string key, Stream stream, FullCourse fullCourse)
        {
            TypeAndName pair;
            string name = key.Substring(key.LastIndexOf('/') + 1);
            models.course.CourseFolder courseFolder = fullCourse.Course;
            if (CourseTypeMap.TryGetValue(name, out pair))
            {
                if (name == "inforef.xml" && !InfoRefTypeMap.TryGetValue("course", out pair))
                    return;
                XmlSerializer serializer = new XmlSerializer(pair.Type);
                var test = serializer.Deserialize(stream);
                courseFolder.GetType().GetProperty(pair.propertyName).SetValue(courseFolder, test);
            }
        }
        private static void ParseSections(string key, Stream stream, FullCourse fullCourse)
        {
            TypeAndName pair;
            int id = Convert.ToInt32(key.Substring(key.IndexOf('_') + 1, ((key.IndexOf('/', key.IndexOf('_') + 1)) - (key.IndexOf('_') + 1))));
            string name = key.Substring(key.LastIndexOf('/') + 1);
            models.section.SectionFolder sectionFolder;
            if (fullCourse.SectionsFolder.ContainsKey(id))
            {
                sectionFolder = fullCourse.SectionsFolder[id];
            }
            else
            {
                sectionFolder = new models.section.SectionFolder();
                fullCourse.SectionsFolder.Add(id, sectionFolder);
            }
            if (SectionTypeMap.TryGetValue(name, out pair))
            {
                if (name == "inforef.xml" && !InfoRefTypeMap.TryGetValue("section", out pair))
                    return;
                XmlSerializer serializer = new XmlSerializer(pair.Type);
                var test = serializer.Deserialize(stream);
                sectionFolder.GetType().GetProperty(pair.propertyName, pair.Type).SetValue(sectionFolder, test);
            }
        }
        private static void ParseFiles(string key, Stream stream, FullCourse fullCourse)
        {
            string name = key.Substring(key.LastIndexOf('/') + 1);
            if (!fullCourse.FilesFolder.ContainsKey(name))
            {
                fullCourse.FilesFolder.Add(name, stream);
            }
        }
        private static void ParseGlobals(string key,Stream stream,FullCourse fullCourse)
        {
            TypeAndName pair;
            if (GlobalsTypeMap.TryGetValue(key, out pair))
            {
                XmlSerializer serializer = new XmlSerializer(pair.Type);
                var test = serializer.Deserialize(stream);
                fullCourse.GetType().GetProperty(pair.propertyName, pair.Type).SetValue(fullCourse, test);
            }

        }

    }
}

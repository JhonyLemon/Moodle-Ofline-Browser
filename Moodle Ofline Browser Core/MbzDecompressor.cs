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
    public struct Pair
    {
        public Pair(Type Type, string propertyName)
        {
            this.Type = Type;
            this.propertyName = propertyName;
        }
        public Type Type { get; }
        public string propertyName { get; }
    }

    public static class MbzDecompressor
    {
        private static Dictionary<string, Pair> TypeMap = new Dictionary<string, Pair>()
        {
            {"badges.xml",new Pair(typeof(models.badges.Badges),"Badges")},
            {"completion.xml",new Pair(typeof(models.completion.Course_completions),"Completion")},
            {"files.xml",new Pair(typeof(models.files.Files),"Files")},
            {"grade_history.xml",new Pair(typeof(models.grade_history.Grade_history),"gradeHistory")},
            {"gradebook.xml",new Pair(typeof(models.gradebook.Gradebook),"Gradebook")},
            {"groups.xml",new Pair(typeof(models.groups.Groups),"Groups")},
            {"moodle_backup.xml",new Pair(typeof(models.moodle_backup.Moodle_backup),"moodleBackup")},
            {"outcomes.xml",new Pair(typeof(models.outcomes.Outcomes),"Outcomes")},
            {"questions.xml",new Pair(typeof(models.questions.Questions),"Questions")},
            {"roles.xml",new Pair(typeof(models.roles.Roles_definition),"Roles")},
            {"scales.xml",new Pair(typeof(models.scales.Scales),"Scales")},
            {"users.xml",new Pair(typeof(models.users.Users),"Users")}
        };


        public static FullCourse Extract(string path)
        {
            FullCourse fullCourse = new FullCourse();
            Pair pair;
            using (Stream stream = File.OpenRead(path))
            {
                var reader = ReaderFactory.Open(stream);
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        /*
                        ExtractionOptions opt = new ExtractionOptions
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        };
                        reader.WriteEntryToDirectory(@"C:\Users\Adam\Downloads\test", opt);
                        */

                        if(TypeMap.TryGetValue(reader.Entry.Key,out pair))
                        {
                            using (EntryStream entryStream = reader.OpenEntryStream())
                            {
                                try
                                {
                                    XmlSerializer serializer = new XmlSerializer(pair.Type);
                                    var test = Convert.ChangeType(serializer.Deserialize(entryStream), pair.Type);
                                    fullCourse.GetType().GetProperty(pair.propertyName, pair.Type).SetValue(fullCourse, test);
                                }
                                catch (Exception e)
                                {

                                }
                            }
                        }
                    }
                }
            }
            return fullCourse;
        }

    }
}

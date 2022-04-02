using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_Core.models
{
    public class FullCourse
    {
        public users.Users Users { get; set; }
        public scales.Scales Scales { get; set; }
        public roles.Roles_definition Roles { get; set; }
        public questions.Question_categories Questions { get; set; }
        public outcomes.Outcomes Outcomes { get; set; }
        public moodle_backup.Moodle_backup moodleBackup { get; set; }
        public groups.Groups Groups { get; set; }
        public gradebook.Gradebook Gradebook { get; set; }
        public grade_history.Grade_history gradeHistory { get; set; }
        public files.Files Files { get; set; }
        public completion.Course_completion Completion { get; set; }
        public badges.Badges Badges { get; set; }
        public Dictionary<int, activities.ActivityFolder> Activities { get; set; }
        public course.CourseFolder Course { get; set; }
        public Dictionary<int, section.SectionFolder> Sections { get; set; }
        public FullCourse()
        {
            this.Activities = new Dictionary<int, activities.ActivityFolder>();
            this.Sections = new Dictionary<int, section.SectionFolder>();
            this.Course = new course.CourseFolder();
        }
    }
}

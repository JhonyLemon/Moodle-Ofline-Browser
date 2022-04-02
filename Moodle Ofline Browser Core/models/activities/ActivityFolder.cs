using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_Core.models.activities
{
    public class ActivityFolder
    {
        public calendar.Events Calendar { get; set; }
        //public comments
        //public competencies
        //public completion
        //public filters
        public grade_history.Grade_history gradeHistory { get; set; }
        public grades.Activity_gradebook activityGradebook { get; set; }
        public inforef.Inforef Inforef { get; set; }
        //public logs
        public logstores.Logstores Logstores { get; set; }
        public module.Module Module { get; set; }
        public roles.Roles Roles { get; set; }
        public grading.Areas Grading { get; set; }
        public activityTypes.Activity ActivityType { get; set; }
    }
}

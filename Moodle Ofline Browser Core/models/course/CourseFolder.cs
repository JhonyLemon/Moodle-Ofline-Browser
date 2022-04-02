using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_Core.models.course
{
    public class CourseFolder
    {
        public logstores.Logstores Logstores {get; set;}
        //  public models.logs.Logs Logs {get; set;}
        public inforef.Inforef Inforef { get; set; }
        //  public models.filters.Filters Filters { get; set; }
        //  public models.competencies.Competencies Competencies { get; set; }
        //  public models.comments.Comments Comments { get; set; }
        //  public models.course.Course Course { get; set; }
        //  public models.contentbank.Contentbank Contentbank { get; set; }
        //  public models.completiondefaults.Completiondefaults Completiondefaults { get; set; }
        public enrolments.Enrolments Enrolments { get; set; }
        public loglastaccess.Lastaccesses LastAccess { get; set; }
        public calendar.Events Calendar { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Models
{
    public class Grade:ModelCategory
    {
        public Grade()
        {
        }
        public string GradeValue { get; set; }
        public string Date { get; set; }
        public string Activity { get; set; }
        public string User { get; set; }


        public Grade(string gradeValue, string date,string activity)
        {
            GradeValue = gradeValue;
            Date = date;
            Activity = activity;
        }

        public Grade(Grade grade) : base(grade)
        {
            GradeValue = grade.GradeValue;
            Date = grade.Date;
            Activity = grade.Activity;
            User = grade.User;
        }
    }
}

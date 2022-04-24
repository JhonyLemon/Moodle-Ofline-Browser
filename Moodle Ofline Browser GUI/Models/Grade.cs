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

        public Grade(string gradeValue, string date)
        {
            GradeValue = gradeValue;
            Date = date;
        }

        public Grade(Grade grade) : base(grade)
        {
            GradeValue = grade.GradeValue;
            Date = grade.Date;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Models
{
    class CourseInfo
    {
        public CourseInfo()
        {
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public CourseInfo(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}

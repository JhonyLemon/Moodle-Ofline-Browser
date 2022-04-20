using Moodle_Ofline_Browser_Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.EventModels
{
    class CourseParsed
    {
        public Moodle_Ofline_Browser_Core.models.FullCourse FullCourse { get; set; }

        public CourseParsed(FullCourse fullCourse)
        {
            FullCourse = fullCourse;
        }
    }
}

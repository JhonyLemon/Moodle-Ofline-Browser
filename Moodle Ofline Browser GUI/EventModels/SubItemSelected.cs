using Moodle_Ofline_Browser_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.EventModels
{
    public class SubItemSelected
    {
        public ModelCategory Category { get; set; }

        public SubItemSelected(ModelCategory category)
        {
            Category = category;
        }
    }
}

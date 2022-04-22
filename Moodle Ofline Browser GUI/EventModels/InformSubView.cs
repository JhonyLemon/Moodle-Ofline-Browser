using Moodle_Ofline_Browser_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.EventModels
{
    public class InformSubView
    {
        public ModelCategory Category { get; set; }

        public InformSubView(ModelCategory categories)
        {
            Category = categories;
        }
    }
}

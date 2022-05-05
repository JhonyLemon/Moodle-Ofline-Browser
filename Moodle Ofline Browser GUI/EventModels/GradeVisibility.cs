using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.EventModels
{
    public class GradeVisibility
    {
        private bool isVisible;

        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }

        public GradeVisibility(bool isVisible)
        {
            IsVisible = isVisible;
        }
    }
}

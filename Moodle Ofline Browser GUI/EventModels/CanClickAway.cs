using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.EventModels
{
    class CanClickAway
    {
        public bool CanClickAwayToClose { get; set; }

        public CanClickAway(bool canClickAwayToClose)
        {
            CanClickAwayToClose = canClickAwayToClose;
        }
    }
}

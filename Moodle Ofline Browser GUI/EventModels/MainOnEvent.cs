using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.EventModels
{
    class MainOnEvent
    {
        public int State { get; set; }

        public MainOnEvent(int state)
        {
            State = state;
        }
    }
}

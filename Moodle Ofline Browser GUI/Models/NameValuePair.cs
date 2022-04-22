using Moodle_Ofline_Browser_GUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Models
{
    public class NameValuePair : ModelCategory
    {
        public NameValuePair()
        {
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public NameValuePair(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}

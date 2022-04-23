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

        private string name;
        public string Name
        {
            get
            {
                if (this.value != null && this.value != "")
                    return this.name + ":";
                return this.name;
            }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string value;
        public string Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value != this.value)
                {
                    this.value = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string NameAndValue
        {
            get
            {
                return Name+" "+Value;
            }
        }

        public NameValuePair(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}

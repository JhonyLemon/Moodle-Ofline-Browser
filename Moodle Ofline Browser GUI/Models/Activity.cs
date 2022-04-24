using Moodle_Ofline_Browser_GUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Models
{
    public class Activity : ModelCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Activity(string id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public Activity()
        {
        }
        public Activity(Activity activity):base(activity)
        {
           this.Id = activity.Id;
           this.Name = activity.Name;
           this.Type = activity.Type;
        }
    }
}

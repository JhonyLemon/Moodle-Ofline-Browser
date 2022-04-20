using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Models
{
    class File
    {
        public File()
        {
        }

        public string Id { get; set; }
        public string User { get; set; }
        public string FileName { get; set; }
        public string Date { get; set; }

        public File(string id, string user, string fileName, string date)
        {
            Id = id;
            User = user;
            FileName = fileName;
            Date = date;
        }
    }
}

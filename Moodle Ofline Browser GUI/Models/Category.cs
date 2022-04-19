using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Models
{
    class Category
    {
        public string CategoryItemName { get; set; }
        public int Id { get; set; }

        public Category(string categoryItemName, int id)
        {
            CategoryItemName = categoryItemName;
            Id = id;
        }
    }
}

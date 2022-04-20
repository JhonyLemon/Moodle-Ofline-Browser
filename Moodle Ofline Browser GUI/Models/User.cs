using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public User(string id, string firstName, string surname, string email)
        {
            Id = id;
            FirstName = firstName;
            Surname = surname;
            Email = email;
        }
        public User(){}
    }
}

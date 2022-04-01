using System.Collections.Generic;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.users
{
    [XmlRoot(ElementName = "users")]
    public class Users
    {
        [XmlElement(ElementName = "user")]
        public List<User> User { get; set; }
    }

}

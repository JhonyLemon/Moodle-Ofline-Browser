using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.users
{
    [XmlRoot(ElementName = "user")]
    public class User
    {
        [XmlElement(ElementName = "username")]
        public string Username { get; set; }
        [XmlElement(ElementName = "idnumber")]
        public string Idnumber { get; set; }
        [XmlElement(ElementName = "email")]
        public string Email { get; set; }
        [XmlElement(ElementName = "phone1")]
        public string Phone1 { get; set; }
        [XmlElement(ElementName = "phone2")]
        public string Phone2 { get; set; }
        [XmlElement(ElementName = "institution")]
        public string Institution { get; set; }
        [XmlElement(ElementName = "department")]
        public string Department { get; set; }
        [XmlElement(ElementName = "address")]
        public string Address { get; set; }
        [XmlElement(ElementName = "city")]
        public string City { get; set; }
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "lastip")]
        public string Lastip { get; set; }
        [XmlElement(ElementName = "picture")]
        public string Picture { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "descriptionformat")]
        public string Descriptionformat { get; set; }
        [XmlElement(ElementName = "imagealt")]
        public string Imagealt { get; set; }
        [XmlElement(ElementName = "auth")]
        public string Auth { get; set; }
        [XmlElement(ElementName = "firstnamephonetic")]
        public string Firstnamephonetic { get; set; }
        [XmlElement(ElementName = "lastnamephonetic")]
        public string Lastnamephonetic { get; set; }
        [XmlElement(ElementName = "middlename")]
        public string Middlename { get; set; }
        [XmlElement(ElementName = "alternatename")]
        public string Alternatename { get; set; }
        [XmlElement(ElementName = "firstname")]
        public string Firstname { get; set; }
        [XmlElement(ElementName = "lastname")]
        public string Lastname { get; set; }
        [XmlElement(ElementName = "confirmed")]
        public string Confirmed { get; set; }
        [XmlElement(ElementName = "policyagreed")]
        public string Policyagreed { get; set; }
        [XmlElement(ElementName = "deleted")]
        public string Deleted { get; set; }
        [XmlElement(ElementName = "lang")]
        public string Lang { get; set; }
        [XmlElement(ElementName = "theme")]
        public string Theme { get; set; }
        [XmlElement(ElementName = "timezone")]
        public string Timezone { get; set; }
        [XmlElement(ElementName = "firstaccess")]
        public string Firstaccess { get; set; }
        [XmlElement(ElementName = "lastaccess")]
        public string Lastaccess { get; set; }
        [XmlElement(ElementName = "lastlogin")]
        public string Lastlogin { get; set; }
        [XmlElement(ElementName = "currentlogin")]
        public string Currentlogin { get; set; }
        [XmlElement(ElementName = "mailformat")]
        public string Mailformat { get; set; }
        [XmlElement(ElementName = "maildigest")]
        public string Maildigest { get; set; }
        [XmlElement(ElementName = "maildisplay")]
        public string Maildisplay { get; set; }
        [XmlElement(ElementName = "autosubscribe")]
        public string Autosubscribe { get; set; }
        [XmlElement(ElementName = "trackforums")]
        public string Trackforums { get; set; }
        [XmlElement(ElementName = "timecreated")]
        public string Timecreated { get; set; }
        [XmlElement(ElementName = "timemodified")]
        public string Timemodified { get; set; }
        [XmlElement(ElementName = "trustbitmask")]
        public string Trustbitmask { get; set; }
        [XmlElement(ElementName = "custom_fields")]
        public string Custom_fields { get; set; }
        [XmlElement(ElementName = "tags")]
        public string Tags { get; set; }
        [XmlElement(ElementName = "preferences")]
        public Preferences Preferences { get; set; }
        [XmlElement(ElementName = "roles")]
        public Roles Roles { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "contextid")]
        public string Contextid { get; set; }
    }
}

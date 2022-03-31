using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "user", Namespace = "")]
	public class User
	{

		[XmlElement(ElementName = "username", Namespace = "")]
		public string Username;

		[XmlElement(ElementName = "idnumber", Namespace = "")]
		public object Idnumber;

		[XmlElement(ElementName = "email", Namespace = "")]
		public string Email;

		[XmlElement(ElementName = "phone1", Namespace = "")]
		public object Phone1;

		[XmlElement(ElementName = "phone2", Namespace = "")]
		public object Phone2;

		[XmlElement(ElementName = "institution", Namespace = "")]
		public object Institution;

		[XmlElement(ElementName = "department", Namespace = "")]
		public object Department;

		[XmlElement(ElementName = "address", Namespace = "")]
		public object Address;

		[XmlElement(ElementName = "city", Namespace = "")]
		public object City;

		[XmlElement(ElementName = "country", Namespace = "")]
		public string Country;

		[XmlElement(ElementName = "lastip", Namespace = "")]
		public string Lastip;

		[XmlElement(ElementName = "picture", Namespace = "")]
		public int Picture;

		[XmlElement(ElementName = "description", Namespace = "")]
		public object Description;

		[XmlElement(ElementName = "descriptionformat", Namespace = "")]
		public int Descriptionformat;

		[XmlElement(ElementName = "imagealt", Namespace = "")]
		public object Imagealt;

		[XmlElement(ElementName = "auth", Namespace = "")]
		public string Auth;

		[XmlElement(ElementName = "firstnamephonetic", Namespace = "")]
		public object Firstnamephonetic;

		[XmlElement(ElementName = "lastnamephonetic", Namespace = "")]
		public object Lastnamephonetic;

		[XmlElement(ElementName = "middlename", Namespace = "")]
		public object Middlename;

		[XmlElement(ElementName = "alternatename", Namespace = "")]
		public object Alternatename;

		[XmlElement(ElementName = "firstname", Namespace = "")]
		public string Firstname;

		[XmlElement(ElementName = "lastname", Namespace = "")]
		public string Lastname;

		[XmlElement(ElementName = "confirmed", Namespace = "")]
		public int Confirmed;

		[XmlElement(ElementName = "policyagreed", Namespace = "")]
		public int Policyagreed;

		[XmlElement(ElementName = "deleted", Namespace = "")]
		public int Deleted;

		[XmlElement(ElementName = "lang", Namespace = "")]
		public string Lang;

		[XmlElement(ElementName = "theme", Namespace = "")]
		public object Theme;

		[XmlElement(ElementName = "timezone", Namespace = "")]
		public string Timezone;

		[XmlElement(ElementName = "firstaccess", Namespace = "")]
		public int Firstaccess;

		[XmlElement(ElementName = "lastaccess", Namespace = "")]
		public int Lastaccess;

		[XmlElement(ElementName = "lastlogin", Namespace = "")]
		public int Lastlogin;

		[XmlElement(ElementName = "currentlogin", Namespace = "")]
		public int Currentlogin;

		[XmlElement(ElementName = "mailformat", Namespace = "")]
		public int Mailformat;

		[XmlElement(ElementName = "maildigest", Namespace = "")]
		public int Maildigest;

		[XmlElement(ElementName = "maildisplay", Namespace = "")]
		public int Maildisplay;

		[XmlElement(ElementName = "autosubscribe", Namespace = "")]
		public int Autosubscribe;

		[XmlElement(ElementName = "trackforums", Namespace = "")]
		public int Trackforums;

		[XmlElement(ElementName = "timecreated", Namespace = "")]
		public int Timecreated;

		[XmlElement(ElementName = "timemodified", Namespace = "")]
		public int Timemodified;

		[XmlElement(ElementName = "trustbitmask", Namespace = "")]
		public int Trustbitmask;

		[XmlElement(ElementName = "custom_fields", Namespace = "")]
		public object CustomFields;

		[XmlElement(ElementName = "tags", Namespace = "")]
		public object Tags;

		[XmlElement(ElementName = "preferences", Namespace = "")]
		public Preferences Preferences;

		[XmlElement(ElementName = "roles", Namespace = "")]
		public Roles Roles;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public int Id;

		[XmlAttribute(AttributeName = "contextid", Namespace = "")]
		public int Contextid;

		[XmlText]
		public string Text;
	}
}

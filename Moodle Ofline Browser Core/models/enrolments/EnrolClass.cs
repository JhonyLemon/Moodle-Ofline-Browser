using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.enrolments
{
	[XmlRoot(ElementName = "enrol")]
	public class EnrolClass
	{
		[XmlElement(ElementName = "enrol")]
		public string Enrol { get; set; }
		[XmlElement(ElementName = "status")]
		public string Status { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "enrolperiod")]
		public string Enrolperiod { get; set; }
		[XmlElement(ElementName = "enrolstartdate")]
		public string Enrolstartdate { get; set; }
		[XmlElement(ElementName = "enrolenddate")]
		public string Enrolenddate { get; set; }
		[XmlElement(ElementName = "expirynotify")]
		public string Expirynotify { get; set; }
		[XmlElement(ElementName = "expirythreshold")]
		public string Expirythreshold { get; set; }
		[XmlElement(ElementName = "notifyall")]
		public string Notifyall { get; set; }
		[XmlElement(ElementName = "password")]
		public string Password { get; set; }
		[XmlElement(ElementName = "cost")]
		public string Cost { get; set; }
		[XmlElement(ElementName = "currency")]
		public string Currency { get; set; }
		[XmlElement(ElementName = "roleid")]
		public string Roleid { get; set; }
		[XmlElement(ElementName = "customint1")]
		public string Customint1 { get; set; }
		[XmlElement(ElementName = "customint2")]
		public string Customint2 { get; set; }
		[XmlElement(ElementName = "customint3")]
		public string Customint3 { get; set; }
		[XmlElement(ElementName = "customint4")]
		public string Customint4 { get; set; }
		[XmlElement(ElementName = "customint5")]
		public string Customint5 { get; set; }
		[XmlElement(ElementName = "customint6")]
		public string Customint6 { get; set; }
		[XmlElement(ElementName = "customint7")]
		public string Customint7 { get; set; }
		[XmlElement(ElementName = "customint8")]
		public string Customint8 { get; set; }
		[XmlElement(ElementName = "customchar1")]
		public string Customchar1 { get; set; }
		[XmlElement(ElementName = "customchar2")]
		public string Customchar2 { get; set; }
		[XmlElement(ElementName = "customchar3")]
		public string Customchar3 { get; set; }
		[XmlElement(ElementName = "customdec1")]
		public string Customdec1 { get; set; }
		[XmlElement(ElementName = "customdec2")]
		public string Customdec2 { get; set; }
		[XmlElement(ElementName = "customtext1")]
		public string Customtext1 { get; set; }
		[XmlElement(ElementName = "customtext2")]
		public string Customtext2 { get; set; }
		[XmlElement(ElementName = "customtext3")]
		public string Customtext3 { get; set; }
		[XmlElement(ElementName = "customtext4")]
		public string Customtext4 { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "user_enrolments")]
		public User_enrolments User_enrolments { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

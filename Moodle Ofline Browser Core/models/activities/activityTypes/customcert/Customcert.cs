using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.customcert
{
	[XmlRoot(ElementName = "customcert")]
	public class Customcert : ActivityType
	{
		[XmlElement(ElementName = "templateid")]
		public string Templateid { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "requiredtime")]
		public string Requiredtime { get; set; }
		[XmlElement(ElementName = "verifyany")]
		public string Verifyany { get; set; }
		[XmlElement(ElementName = "emailstudents")]
		public string Emailstudents { get; set; }
		[XmlElement(ElementName = "emailteachers")]
		public string Emailteachers { get; set; }
		[XmlElement(ElementName = "emailothers")]
		public string Emailothers { get; set; }
		[XmlElement(ElementName = "protection")]
		public string Protection { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "issues")]
		public Issues Issues { get; set; }
		[XmlElement(ElementName = "template")]
		public Template Template { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.enrolments
{
	[XmlRoot(ElementName = "enrolment")]
	public class Enrolment
	{
		[XmlElement(ElementName = "status")]
		public string Status { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "timestart")]
		public string Timestart { get; set; }
		[XmlElement(ElementName = "timeend")]
		public string Timeend { get; set; }
		[XmlElement(ElementName = "modifierid")]
		public string Modifierid { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

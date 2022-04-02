using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance
{
	[XmlRoot(ElementName = "status")]
	public class Status
	{
		[XmlElement(ElementName = "acronym")]
		public string Acronym { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "grade")]
		public string Grade { get; set; }
		[XmlElement(ElementName = "studentavailability")]
		public string Studentavailability { get; set; }
		[XmlElement(ElementName = "setunmarked")]
		public string Setunmarked { get; set; }
		[XmlElement(ElementName = "visible")]
		public string Visible { get; set; }
		[XmlElement(ElementName = "deleted")]
		public string Deleted { get; set; }
		[XmlElement(ElementName = "setnumber")]
		public string Setnumber { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes
{
	[XmlRoot(ElementName = "activity")]
	public class Activity
	{
        [XmlElement(ElementName = "attendance", Type = typeof(Attendance))]
        [XmlElement(ElementName = "assign", Type = typeof(Assign))]
		public ActivityType ActivityType { get; set; }

        [XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "moduleid")]
		public string Moduleid { get; set; }
		[XmlAttribute(AttributeName = "modulename")]
		public string Modulename { get; set; }
		[XmlAttribute(AttributeName = "contextid")]
		public string Contextid { get; set; }
	}
}

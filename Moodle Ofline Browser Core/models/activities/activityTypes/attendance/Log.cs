using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance
{
	[XmlRoot(ElementName = "log", Namespace = "attendance")]
	public class Log
	{
		[XmlElement(ElementName = "sessionid")]
		public string Sessionid { get; set; }
		[XmlElement(ElementName = "studentid")]
		public string Studentid { get; set; }
		[XmlElement(ElementName = "statusid")]
		public string Statusid { get; set; }
		[XmlElement(ElementName = "statusset")]
		public string Statusset { get; set; }
		[XmlElement(ElementName = "timetaken")]
		public string Timetaken { get; set; }
		[XmlElement(ElementName = "takenby")]
		public string Takenby { get; set; }
		[XmlElement(ElementName = "remarks")]
		public string Remarks { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.bigbluebuttonbn
{
	[XmlRoot(ElementName = "log", Namespace = "bigbluebuttonbn")]
	public class Log
	{
		[XmlElement(ElementName = "courseid")]
		public string Courseid { get; set; }
		[XmlElement(ElementName = "bigbluebuttonbnid")]
		public string Bigbluebuttonbnid { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "meetingid")]
		public string Meetingid { get; set; }
		[XmlElement(ElementName = "log")]
		public string _Log { get; set; }
		[XmlElement(ElementName = "meta")]
		public string Meta { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

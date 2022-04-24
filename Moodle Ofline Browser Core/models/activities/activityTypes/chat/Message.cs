using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.chat
{
	[XmlRoot(ElementName = "message")]
	public class Message
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "groupid")]
		public string Groupid { get; set; }
		[XmlElement(ElementName = "system")]
		public string System { get; set; }
		[XmlElement(ElementName = "message_text")]
		public string Message_text { get; set; }
		[XmlElement(ElementName = "timestamp")]
		public string Timestamp { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

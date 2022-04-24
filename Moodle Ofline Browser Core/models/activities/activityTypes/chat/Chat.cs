using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.chat
{
	[XmlRoot(ElementName = "chat")]
	public class Chat : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "keepdays")]
		public string Keepdays { get; set; }
		[XmlElement(ElementName = "studentlogs")]
		public string Studentlogs { get; set; }
		[XmlElement(ElementName = "chattime")]
		public string Chattime { get; set; }
		[XmlElement(ElementName = "schedule")]
		public string Schedule { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "messages")]
		public Messages Messages { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

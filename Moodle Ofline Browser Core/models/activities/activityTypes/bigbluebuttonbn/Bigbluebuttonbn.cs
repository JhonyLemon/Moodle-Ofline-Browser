using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.bigbluebuttonbn
{
	[XmlRoot(ElementName = "bigbluebuttonbn")]
	public class Bigbluebuttonbn:ActivityType
	{
		[XmlElement(ElementName = "type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "course")]
		public string Course { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "meetingid")]
		public string Meetingid { get; set; }
		[XmlElement(ElementName = "moderatorpass")]
		public string Moderatorpass { get; set; }
		[XmlElement(ElementName = "viewerpass")]
		public string Viewerpass { get; set; }
		[XmlElement(ElementName = "wait")]
		public string Wait { get; set; }
		[XmlElement(ElementName = "record")]
		public string Record { get; set; }
		[XmlElement(ElementName = "recordallfromstart")]
		public string Recordallfromstart { get; set; }
		[XmlElement(ElementName = "recordhidebutton")]
		public string Recordhidebutton { get; set; }
		[XmlElement(ElementName = "welcome")]
		public string Welcome { get; set; }
		[XmlElement(ElementName = "voicebridge")]
		public string Voicebridge { get; set; }
		[XmlElement(ElementName = "openingtime")]
		public string Openingtime { get; set; }
		[XmlElement(ElementName = "closingtime")]
		public string Closingtime { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "presentation")]
		public string Presentation { get; set; }
		[XmlElement(ElementName = "participants")]
		public string Participants { get; set; }
		[XmlElement(ElementName = "userlimit")]
		public string Userlimit { get; set; }
		[XmlElement(ElementName = "recordings_html")]
		public string Recordings_html { get; set; }
		[XmlElement(ElementName = "recordings_deleted")]
		public string Recordings_deleted { get; set; }
		[XmlElement(ElementName = "recordings_imported")]
		public string Recordings_imported { get; set; }
		[XmlElement(ElementName = "recordings_preview")]
		public string Recordings_preview { get; set; }
		[XmlElement(ElementName = "clienttype")]
		public string Clienttype { get; set; }
		[XmlElement(ElementName = "muteonstart")]
		public string Muteonstart { get; set; }
		[XmlElement(ElementName = "completionattendance")]
		public string Completionattendance { get; set; }
		[XmlElement(ElementName = "completionengagementchats")]
		public string Completionengagementchats { get; set; }
		[XmlElement(ElementName = "completionengagementtalks")]
		public string Completionengagementtalks { get; set; }
		[XmlElement(ElementName = "completionengagementraisehand")]
		public string Completionengagementraisehand { get; set; }
		[XmlElement(ElementName = "completionengagementpollvotes")]
		public string Completionengagementpollvotes { get; set; }
		[XmlElement(ElementName = "completionengagementemojis")]
		public string Completionengagementemojis { get; set; }
		[XmlElement(ElementName = "logs", Namespace = "bigbluebuttonbn")]
		public Logs Logs { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

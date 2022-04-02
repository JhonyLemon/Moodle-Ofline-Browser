using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.calendar
{
	[XmlRoot(ElementName = "event")]
	public class Event
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "format")]
		public string Format { get; set; }
		[XmlElement(ElementName = "courseid")]
		public string Courseid { get; set; }
		[XmlElement(ElementName = "groupid")]
		public string Groupid { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "repeatid")]
		public string Repeatid { get; set; }
		[XmlElement(ElementName = "modulename")]
		public string Modulename { get; set; }
		[XmlElement(ElementName = "instance")]
		public string Instance { get; set; }
		[XmlElement(ElementName = "type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "eventtype")]
		public string Eventtype { get; set; }
		[XmlElement(ElementName = "timestart")]
		public string Timestart { get; set; }
		[XmlElement(ElementName = "timeduration")]
		public string Timeduration { get; set; }
		[XmlElement(ElementName = "timesort")]
		public string Timesort { get; set; }
		[XmlElement(ElementName = "visible")]
		public string Visible { get; set; }
		[XmlElement(ElementName = "uuid")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "sequence")]
		public string Sequence { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "priority")]
		public string Priority { get; set; }
		[XmlElement(ElementName = "location")]
		public string Location { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

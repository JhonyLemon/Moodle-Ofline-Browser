using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.book
{



	[XmlRoot(ElementName = "book")]
	public class Book : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "numbering")]
		public string Numbering { get; set; }
		[XmlElement(ElementName = "navstyle")]
		public string Navstyle { get; set; }
		[XmlElement(ElementName = "customtitles")]
		public string Customtitles { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "chapters")]
		public Chapters Chapters { get; set; }
		[XmlElement(ElementName = "chaptertags")]
		public string Chaptertags { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

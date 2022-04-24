using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.page
{
	[XmlRoot(ElementName = "page")]
	public class Page : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "content")]
		public string Content { get; set; }
		[XmlElement(ElementName = "contentformat")]
		public string Contentformat { get; set; }
		[XmlElement(ElementName = "legacyfiles")]
		public string Legacyfiles { get; set; }
		[XmlElement(ElementName = "legacyfileslast")]
		public string Legacyfileslast { get; set; }
		[XmlElement(ElementName = "display")]
		public string Display { get; set; }
		[XmlElement(ElementName = "displayoptions")]
		public string Displayoptions { get; set; }
		[XmlElement(ElementName = "revision")]
		public string Revision { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.book
{
	[XmlRoot(ElementName = "chapter")]
	public class Chapter
	{
		[XmlElement(ElementName = "pagenum")]
		public string Pagenum { get; set; }
		[XmlElement(ElementName = "subchapter")]
		public string Subchapter { get; set; }
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "content")]
		public string Content { get; set; }
		[XmlElement(ElementName = "contentformat")]
		public string Contentformat { get; set; }
		[XmlElement(ElementName = "hidden")]
		public string Hidden { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "importsrc")]
		public string Importsrc { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

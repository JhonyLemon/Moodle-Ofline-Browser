using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.customcert
{
	[XmlRoot(ElementName = "page", Namespace = "customcert")]
	public class Page
	{
		[XmlElement(ElementName = "templateid")]
		public string Templateid { get; set; }
		[XmlElement(ElementName = "width")]
		public string Width { get; set; }
		[XmlElement(ElementName = "height")]
		public string Height { get; set; }
		[XmlElement(ElementName = "leftmargin")]
		public string Leftmargin { get; set; }
		[XmlElement(ElementName = "rightmargin")]
		public string Rightmargin { get; set; }
		[XmlElement(ElementName = "sequence")]
		public string Sequence { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

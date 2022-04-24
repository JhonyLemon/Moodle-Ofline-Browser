using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.customcert
{
	[XmlRoot(ElementName = "template")]
	public class Template
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "contextid")]
		public string Contextid { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "pages")]
		public Pages Pages { get; set; }
		[XmlAttribute(AttributeName = "id", Namespace = "customcert")]
		public string Id { get; set; }
	}
}

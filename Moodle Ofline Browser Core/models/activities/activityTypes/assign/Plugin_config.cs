using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "plugin_config")]
	public class Plugin_config
	{
		[XmlElement(ElementName = "plugin")]
		public string Plugin { get; set; }
		[XmlElement(ElementName = "subtype")]
		public string Subtype { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

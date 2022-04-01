using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.roles
{
	[XmlRoot(ElementName = "role")]
	public class Role
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "shortname")]
		public string Shortname { get; set; }
		[XmlElement(ElementName = "nameincourse")]
		public string Nameincourse { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "sortorder")]
		public string Sortorder { get; set; }
		[XmlElement(ElementName = "archetype")]
		public string Archetype { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

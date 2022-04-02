using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.badges
{
	[XmlRoot(ElementName = "parameter")]
	public class Parameter
	{
		[XmlElement(ElementName = "critid")]
		public string Critid { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "value")]
		public string Value { get; set; }
		[XmlElement(ElementName = "criteriatype")]
		public string Criteriatype { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

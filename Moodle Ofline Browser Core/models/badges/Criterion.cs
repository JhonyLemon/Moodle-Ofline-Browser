using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.badges
{
	[XmlRoot(ElementName = "criterion")]
	public class Criterion
	{
		[XmlElement(ElementName = "badgeid")]
		public string Badgeid { get; set; }
		[XmlElement(ElementName = "criteriatype")]
		public string Criteriatype { get; set; }
		[XmlElement(ElementName = "method")]
		public string Method { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "descriptionformat")]
		public string Descriptionformat { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "parameters")]
		public Parameters Parameters { get; set; }
	}

}

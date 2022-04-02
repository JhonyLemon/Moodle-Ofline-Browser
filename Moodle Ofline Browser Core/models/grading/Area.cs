using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.grading
{
	[XmlRoot(ElementName = "area")]
	public class Area
	{
		[XmlElement(ElementName = "areaname")]
		public string Areaname { get; set; }
		[XmlElement(ElementName = "activemethod")]
		public string Activemethod { get; set; }
		[XmlElement(ElementName = "definitions")]
		public string Definitions { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

}

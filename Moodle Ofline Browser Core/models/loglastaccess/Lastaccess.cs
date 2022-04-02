using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.loglastaccess
{
		[XmlRoot(ElementName = "lastaccess")]
		public class Lastaccess
		{
			[XmlElement(ElementName = "userid")]
			public string Userid { get; set; }
			[XmlElement(ElementName = "timeaccess")]
			public string Timeaccess { get; set; }
			[XmlAttribute(AttributeName = "id")]
			public string Id { get; set; }
		}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.logstores
{
		[XmlRoot(ElementName = "logstores")]
		public class Logstores
		{
			[XmlElement(ElementName = "logstore")]
			public Logstore Logstore { get; set; }
		}
}

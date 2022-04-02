using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.logstores
{
	[XmlRoot(ElementName = "subplugin_logstore_standard_logstore")]
	public class Subplugin_logstore_standard_logstore
	{
		[XmlElement(ElementName = "logstore_standard_log")]
		public List<Logstore_standard_log> Logstore_standard_log { get; set; }
	}
}

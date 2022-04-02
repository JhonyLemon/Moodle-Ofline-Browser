using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.logstores
{
	[XmlRoot(ElementName = "logstore")]
	public class Logstore
	{
		[XmlElement(ElementName = "subplugin_logstore_database_logstore")]
		public string Subplugin_logstore_database_logstore { get; set; }
		[XmlElement(ElementName = "subplugin_logstore_standard_logstore")]
		public Subplugin_logstore_standard_logstore Subplugin_logstore_standard_logstore { get; set; }
	}
}

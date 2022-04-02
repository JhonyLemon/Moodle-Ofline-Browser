using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "plugin_configs")]
	public class Plugin_configs
	{
		[XmlElement(ElementName = "plugin_config")]
		public List<Plugin_config> Plugin_config { get; set; }
	}
}

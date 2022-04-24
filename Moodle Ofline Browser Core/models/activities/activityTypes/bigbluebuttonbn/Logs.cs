using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.bigbluebuttonbn
{
	[XmlRoot(ElementName = "logs", Namespace = "bigbluebuttonbn")]
	public class Logs
	{
		[XmlElement(ElementName = "log",Namespace ="bigbluebuttonbn")]
		public List<Log> Log { get; set; }
	}
}

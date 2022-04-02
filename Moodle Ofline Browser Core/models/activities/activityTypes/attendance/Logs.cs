using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance
{
	[XmlRoot(ElementName = "logs")]
	public class Logs
	{
		[XmlElement(ElementName = "log")]
		public Log Log { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance
{
	[XmlRoot(ElementName = "statuses")]
	public class Statuses
	{
		[XmlElement(ElementName = "status")]
		public List<Status> Status { get; set; }
	}
}

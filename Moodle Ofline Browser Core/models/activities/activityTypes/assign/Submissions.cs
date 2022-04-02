using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "submissions")]
	public class Submissions
	{
		[XmlElement(ElementName = "submission")]
		public Submission Submission { get; set; }
	}
}

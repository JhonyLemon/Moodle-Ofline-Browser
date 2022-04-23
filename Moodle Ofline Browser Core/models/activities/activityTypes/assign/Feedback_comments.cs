using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "feedback_comments")]
	public class Feedback_comments
	{
		[XmlElement(ElementName = "commenttext")]
		public string Commenttext { get; set; }
		[XmlElement(ElementName = "commentformat")]
		public string Commentformat { get; set; }
		[XmlElement(ElementName = "grade")]
		public string Grade { get; set; }
	}
}

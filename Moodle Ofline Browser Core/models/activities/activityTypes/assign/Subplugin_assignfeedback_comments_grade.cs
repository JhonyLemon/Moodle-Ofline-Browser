using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "subplugin_assignfeedback_comments_grade")]
	public class Subplugin_assignfeedback_comments_grade
	{
		[XmlElement(ElementName = "feedback_comments")]
		public Feedback_comments Feedback_comments { get; set; }
	}
}

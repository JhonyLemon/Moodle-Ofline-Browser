using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "feedback_editpdf_rotation")]
	public class Feedback_editpdf_rotation
	{
		[XmlElement(ElementName = "pagerotation")]
		public Pagerotation Pagerotation { get; set; }
	}
}

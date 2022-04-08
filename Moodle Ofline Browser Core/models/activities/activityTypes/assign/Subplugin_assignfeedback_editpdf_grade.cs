using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "subplugin_assignfeedback_editpdf_grade")]
	public class Subplugin_assignfeedback_editpdf_grade
	{
		[XmlElement(ElementName = "feedback_editpdf_files")]
		public Feedback_editpdf_files Feedback_editpdf_files { get; set; }
		[XmlElement(ElementName = "feedback_editpdf_annotations")]
		public string Feedback_editpdf_annotations { get; set; }
		[XmlElement(ElementName = "feedback_editpdf_comments")]
		public string Feedback_editpdf_comments { get; set; }
		[XmlElement(ElementName = "feedback_editpdf_rotation")]
		public Feedback_editpdf_rotation Feedback_editpdf_rotation { get; set; }
	}
}

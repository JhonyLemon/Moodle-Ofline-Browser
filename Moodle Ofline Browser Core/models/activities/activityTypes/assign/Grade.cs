using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "grade")]
	public class Grade
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "grader")]
		public string Grader { get; set; }
		[XmlElement(ElementName = "grade")]
		public string GradeValue { get; set; }
		[XmlElement(ElementName = "attemptnumber")]
		public string Attemptnumber { get; set; }
		[XmlElement(ElementName = "subplugin_assignfeedback_comments_grade")]
		public string Subplugin_assignfeedback_comments_grade { get; set; }
		[XmlElement(ElementName = "subplugin_assignfeedback_editpdf_grade")]
		public Subplugin_assignfeedback_editpdf_grade Subplugin_assignfeedback_editpdf_grade { get; set; }
		[XmlElement(ElementName = "subplugin_assignfeedback_file_grade")]
		public string Subplugin_assignfeedback_file_grade { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

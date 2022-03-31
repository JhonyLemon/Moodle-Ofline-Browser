using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "grade_grades", Namespace = "")]
	public class GradeGrades
	{

		[XmlElement(ElementName = "grade_grade", Namespace = "")]
		public GradeGrade GradeGrade;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.gradebook
{
	[XmlRoot(ElementName = "grade_grades")]
	public class Grade_grades
	{
		[XmlElement(ElementName = "grade_grade")]
		public Grade_grade Grade_grade { get; set; }
	}
}

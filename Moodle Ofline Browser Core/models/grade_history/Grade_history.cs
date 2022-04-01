using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.grade_history
{
	[XmlRoot(ElementName = "grade_history")]
	public class Grade_history
	{
		[XmlElement(ElementName = "grade_grades")]
		public Grade_grades Grade_grades { get; set; }
	}
}

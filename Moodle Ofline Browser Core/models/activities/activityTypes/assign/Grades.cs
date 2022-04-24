using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "grades", Namespace = "assign")]
	public class Grades
	{
		[XmlElement(ElementName = "grade", Namespace = "assign")]
		public List<Grade> Grade { get; set; }
	}
}

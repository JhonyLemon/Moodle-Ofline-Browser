using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "grades")]
	public class Grades
	{
		[XmlElement(ElementName = "grade")]
		public Grade Grade { get; set; }
	}
}

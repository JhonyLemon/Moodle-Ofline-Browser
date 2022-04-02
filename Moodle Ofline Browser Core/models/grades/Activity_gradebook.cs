using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle_Ofline_Browser_Core.models.gradebook;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.grades
{
	[XmlRoot(ElementName = "activity_gradebook")]
	public class Activity_gradebook
	{
		[XmlElement(ElementName = "grade_items")]
		public Grade_items Grade_items { get; set; }
		[XmlElement(ElementName = "grade_letters")]
		public string Grade_letters { get; set; }
	}
}

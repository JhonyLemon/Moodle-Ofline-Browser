using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.gradebook
{
	[XmlRoot(ElementName = "grade_settings")]
	public class Grade_settings
	{
		[XmlElement(ElementName = "grade_setting")]
		public Grade_setting Grade_setting { get; set; }
	}
}

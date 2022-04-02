using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.enrolments
{
	[XmlRoot(ElementName = "user_enrolments")]
	public class User_enrolments
	{
		[XmlElement(ElementName = "enrolment")]
		public Enrolment Enrolment { get; set; }
	}
}

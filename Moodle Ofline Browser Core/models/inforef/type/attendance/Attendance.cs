using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.inforef.type.attendance
{
	[XmlRoot(ElementName = "inforef")]
	public class Attendance : inforef.Inforef
	{
		[XmlElement(ElementName = "grade_itemref")]
		public Grade_itemref Grade_itemref { get; set; }
	}
}

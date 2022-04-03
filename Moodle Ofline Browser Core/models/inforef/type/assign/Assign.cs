using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.inforef.type.assign
{

	[XmlRoot(ElementName = "inforef")]
	public class Assign : inforef.Inforef
	{
		[XmlElement(ElementName = "grade_itemref")]
		public Grade_itemref Grade_itemref { get; set; }
	}
}

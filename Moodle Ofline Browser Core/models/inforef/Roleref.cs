using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.inforef
{
	[XmlRoot(ElementName = "roleref")]
	public class Roleref
	{
		[XmlElement(ElementName = "role")]
		public Role Role { get; set; }
	}
}

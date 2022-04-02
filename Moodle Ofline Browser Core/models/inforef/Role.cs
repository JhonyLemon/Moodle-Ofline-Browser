using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.inforef
{
	[XmlRoot(ElementName = "role")]
	public class Role
	{
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
	}
}

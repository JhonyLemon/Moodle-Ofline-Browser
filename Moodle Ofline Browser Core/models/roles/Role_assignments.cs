using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.roles
{
	[XmlRoot(ElementName = "role_assignments")]
	public class Role_assignments
	{
		[XmlElement(ElementName = "assignment")]
		public Assignment Assignment { get; set; }
	}
}

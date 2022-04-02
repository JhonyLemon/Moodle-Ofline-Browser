using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.roles
{
		[XmlRoot(ElementName = "roles")]
		public class Roles
		{
			[XmlElement(ElementName = "role_overrides")]
			public string Role_overrides { get; set; }
			[XmlElement(ElementName = "role_assignments")]
			public Role_assignments Role_assignments { get; set; }
		}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "roles_definition", Namespace = "")]
	public class RolesDefinition
	{

		[XmlElement(ElementName = "role", Namespace = "")]
		public Role Role;
	}
}

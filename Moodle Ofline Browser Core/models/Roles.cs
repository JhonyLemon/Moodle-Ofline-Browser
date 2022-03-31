using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "roles", Namespace = "")]
	public class Roles
	{

		[XmlElement(ElementName = "role_overrides", Namespace = "")]
		public object RoleOverrides;

		[XmlElement(ElementName = "role_assignments", Namespace = "")]
		public object RoleAssignments;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.groups
{
	[XmlRoot(ElementName = "group_members")]
	public class Group_members
	{
		[XmlElement(ElementName = "group_member")]
		public Group_member Group_member { get; set; }
	}
}

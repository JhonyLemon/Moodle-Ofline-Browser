using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.groups
{
		[XmlRoot(ElementName = "groups")]
		public class Groups
		{
			[XmlElement(ElementName = "group")]
			public Group Group { get; set; }
			[XmlElement(ElementName = "groupings")]
			public string Groupings { get; set; }
		}
}

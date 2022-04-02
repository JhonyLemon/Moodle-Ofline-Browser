using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.groups
{
	[XmlRoot(ElementName = "group_member")]
	public class Group_member
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "timeadded")]
		public string Timeadded { get; set; }
		[XmlElement(ElementName = "component")]
		public string Component { get; set; }
		[XmlElement(ElementName = "itemid")]
		public string Itemid { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

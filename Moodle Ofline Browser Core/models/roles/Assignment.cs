using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.roles
{
	[XmlRoot(ElementName = "assignment")]
	public class Assignment
	{
		[XmlElement(ElementName = "roleid")]
		public string Roleid { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "modifierid")]
		public string Modifierid { get; set; }
		[XmlElement(ElementName = "component")]
		public string Component { get; set; }
		[XmlElement(ElementName = "itemid")]
		public string Itemid { get; set; }
		[XmlElement(ElementName = "sortorder")]
		public string Sortorder { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

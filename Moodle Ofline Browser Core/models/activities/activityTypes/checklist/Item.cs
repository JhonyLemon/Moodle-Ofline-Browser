using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.checklist
{
	[XmlRoot(ElementName = "item")]
	public class Item
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "displaytext")]
		public string Displaytext { get; set; }
		[XmlElement(ElementName = "position")]
		public string Position { get; set; }
		[XmlElement(ElementName = "indent")]
		public string Indent { get; set; }
		[XmlElement(ElementName = "itemoptional")]
		public string Itemoptional { get; set; }
		[XmlElement(ElementName = "duetime")]
		public string Duetime { get; set; }
		[XmlElement(ElementName = "colour")]
		public string Colour { get; set; }
		[XmlElement(ElementName = "moduleid")]
		public string Moduleid { get; set; }
		[XmlElement(ElementName = "hidden")]
		public string Hidden { get; set; }
		[XmlElement(ElementName = "linkcourseid")]
		public string Linkcourseid { get; set; }
		[XmlElement(ElementName = "linkurl")]
		public string Linkurl { get; set; }
		[XmlElement(ElementName = "checks")]
		public Checks Checks { get; set; }
		[XmlElement(ElementName = "comments")]
		public string Comments { get; set; }
		[XmlElement(ElementName = "studentcomments")]
		public string Studentcomments { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

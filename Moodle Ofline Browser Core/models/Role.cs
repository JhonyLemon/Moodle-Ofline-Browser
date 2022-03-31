using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(RolesDefinition));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (RolesDefinition)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "role", Namespace = "")]
	public class Role
	{

		[XmlElement(ElementName = "name", Namespace = "")]
		public object Name;

		[XmlElement(ElementName = "shortname", Namespace = "")]
		public string Shortname;

		[XmlElement(ElementName = "nameincourse", Namespace = "")]
		public string Nameincourse;

		[XmlElement(ElementName = "description", Namespace = "")]
		public object Description;

		[XmlElement(ElementName = "sortorder", Namespace = "")]
		public int Sortorder;

		[XmlElement(ElementName = "archetype", Namespace = "")]
		public string Archetype;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public int Id;

		[XmlText]
		public string Text;
	}
}

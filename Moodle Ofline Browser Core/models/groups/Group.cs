using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.groups
{
	[XmlRoot(ElementName = "group")]
	public class Group
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "idnumber")]
		public string Idnumber { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "descriptionformat")]
		public string Descriptionformat { get; set; }
		[XmlElement(ElementName = "enrolmentkey")]
		public string Enrolmentkey { get; set; }
		[XmlElement(ElementName = "picture")]
		public string Picture { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "group_members")]
		public Group_members Group_members { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

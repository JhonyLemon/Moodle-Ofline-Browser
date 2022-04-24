using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.folder
{
	[XmlRoot(ElementName = "folder")]
	public class Folder : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "revision")]
		public string Revision { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "display")]
		public string Display { get; set; }
		[XmlElement(ElementName = "showexpanded")]
		public string Showexpanded { get; set; }
		[XmlElement(ElementName = "showdownloadfolder")]
		public string Showdownloadfolder { get; set; }
		[XmlElement(ElementName = "forcedownload")]
		public string Forcedownload { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

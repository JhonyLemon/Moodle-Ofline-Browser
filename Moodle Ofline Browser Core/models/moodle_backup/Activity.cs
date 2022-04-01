using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.moodle_backup
{
	[XmlRoot(ElementName = "activity")]
	public class Activity
	{
		[XmlElement(ElementName = "moduleid")]
		public string Moduleid { get; set; }
		[XmlElement(ElementName = "sectionid")]
		public string Sectionid { get; set; }
		[XmlElement(ElementName = "modulename")]
		public string Modulename { get; set; }
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "directory")]
		public string Directory { get; set; }
	}
}

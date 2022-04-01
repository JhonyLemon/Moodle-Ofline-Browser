using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.moodle_backup
{
	[XmlRoot(ElementName = "section")]
	public class Section
	{
		[XmlElement(ElementName = "sectionid")]
		public string Sectionid { get; set; }
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "directory")]
		public string Directory { get; set; }
	}
}

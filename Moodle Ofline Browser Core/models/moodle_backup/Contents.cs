using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.moodle_backup
{
	[XmlRoot(ElementName = "contents")]
	public class Contents
	{
		[XmlElement(ElementName = "activities")]
		public Activities Activities { get; set; }
		[XmlElement(ElementName = "sections")]
		public Sections Sections { get; set; }
		[XmlElement(ElementName = "course")]
		public Course Course { get; set; }
	}
}

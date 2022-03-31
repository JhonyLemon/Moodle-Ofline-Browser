using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "section", Namespace = "")]
	public class Section
	{

		[XmlElement(ElementName = "sectionid", Namespace = "")]
		public int Sectionid;

		[XmlElement(ElementName = "title", Namespace = "")]
		public int Title;

		[XmlElement(ElementName = "directory", Namespace = "")]
		public string Directory;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "activity", Namespace = "")]
	public class Activity
	{

		[XmlElement(ElementName = "moduleid", Namespace = "")]
		public int Moduleid;

		[XmlElement(ElementName = "sectionid", Namespace = "")]
		public int Sectionid;

		[XmlElement(ElementName = "modulename", Namespace = "")]
		public string Modulename;

		[XmlElement(ElementName = "title", Namespace = "")]
		public string Title;

		[XmlElement(ElementName = "directory", Namespace = "")]
		public string Directory;
	}
}

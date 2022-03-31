using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "course", Namespace = "")]
	public class Course
	{

		[XmlElement(ElementName = "courseid", Namespace = "")]
		public int Courseid;

		[XmlElement(ElementName = "title", Namespace = "")]
		public string Title;

		[XmlElement(ElementName = "directory", Namespace = "")]
		public string Directory;
	}
}

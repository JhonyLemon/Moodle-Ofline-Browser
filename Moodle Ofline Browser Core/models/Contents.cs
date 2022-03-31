using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "contents", Namespace = "")]
	public class Contents
	{

		[XmlElement(ElementName = "activities", Namespace = "")]
		public Activities Activities;

		[XmlElement(ElementName = "sections", Namespace = "")]
		public Sections Sections;

		[XmlElement(ElementName = "course", Namespace = "")]
		public Course Course;
	}
}

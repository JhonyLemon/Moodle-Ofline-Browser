using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "sections", Namespace = "")]
	public class Sections
	{

		[XmlElement(ElementName = "section", Namespace = "")]
		public List<Section> Section;
	}
}

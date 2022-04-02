using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.loglastaccess
{
	[XmlRoot(ElementName = "lastaccesses")]
	public class Lastaccesses
	{
		[XmlElement(ElementName = "lastaccess")]
		public List<Lastaccess> Lastaccess { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.questions
{
	[XmlRoot(ElementName = "plugin_qtype_ddmarker_question")]
	public class Plugin_qtype_ddmarker_question
	{
		[XmlElement(ElementName = "ddmarker")]
		public Ddmarker Ddmarker { get; set; }
		[XmlElement(ElementName = "drags")]
		public string Drags { get; set; }
		[XmlElement(ElementName = "drops")]
		public string Drops { get; set; }
	}
}

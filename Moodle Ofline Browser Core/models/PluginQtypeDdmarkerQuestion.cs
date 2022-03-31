using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "plugin_qtype_ddmarker_question", Namespace = "")]
	public class PluginQtypeDdmarkerQuestion
	{

		[XmlElement(ElementName = "ddmarker", Namespace = "")]
		public Ddmarker Ddmarker;

		[XmlElement(ElementName = "drags", Namespace = "")]
		public object Drags;

		[XmlElement(ElementName = "drops", Namespace = "")]
		public object Drops;
	}
}

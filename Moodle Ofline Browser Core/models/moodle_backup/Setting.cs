using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.moodle_backup
{
	[XmlRoot(ElementName = "setting")]
	public class Setting
	{
		[XmlElement(ElementName = "level")]
		public string Level { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "value")]
		public string Value { get; set; }
		[XmlElement(ElementName = "section")]
		public string Section { get; set; }
		[XmlElement(ElementName = "activity")]
		public string Activity { get; set; }
	}
}

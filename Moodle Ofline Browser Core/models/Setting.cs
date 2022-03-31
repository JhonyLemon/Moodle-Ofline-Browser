using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "setting", Namespace = "")]
	public class Setting
	{

		[XmlElement(ElementName = "level", Namespace = "")]
		public string Level;

		[XmlElement(ElementName = "name", Namespace = "")]
		public string Name;

		[XmlElement(ElementName = "value", Namespace = "")]
		public string Value;

		[XmlElement(ElementName = "section", Namespace = "")]
		public string Section;

		[XmlElement(ElementName = "activity", Namespace = "")]
		public string Activity;
	}
}

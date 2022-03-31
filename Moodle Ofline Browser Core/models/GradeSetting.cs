using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "grade_setting", Namespace = "")]
	public class GradeSetting
	{

		[XmlElement(ElementName = "name", Namespace = "")]
		public string Name;

		[XmlElement(ElementName = "value", Namespace = "")]
		public int Value;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public object Id;

		[XmlText]
		public string Text;
	}
}

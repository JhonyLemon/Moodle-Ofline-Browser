using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.choice
{
	[XmlRoot(ElementName = "option")]
	public class Option
	{
		[XmlElement(ElementName = "text")]
		public string Text { get; set; }
		[XmlElement(ElementName = "maxanswers")]
		public string Maxanswers { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

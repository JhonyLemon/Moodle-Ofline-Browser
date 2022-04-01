using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.gradebook
{
	[XmlRoot(ElementName = "gradebook")]
	public class Gradebook
	{
		[XmlElement(ElementName = "attributes")]
		public string Attributes { get; set; }
		[XmlElement(ElementName = "grade_categories")]
		public Grade_categories Grade_categories { get; set; }
		[XmlElement(ElementName = "grade_items")]
		public Grade_items Grade_items { get; set; }
		[XmlElement(ElementName = "grade_letters")]
		public string Grade_letters { get; set; }
		[XmlElement(ElementName = "grade_settings")]
		public Grade_settings Grade_settings { get; set; }
	}
}

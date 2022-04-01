using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.completion
{
	[XmlRoot(ElementName = "course_completions")]
	public class Course_completions
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "course")]
		public string Course { get; set; }
		[XmlElement(ElementName = "timeenrolled")]
		public string Timeenrolled { get; set; }
		[XmlElement(ElementName = "timestarted")]
		public string Timestarted { get; set; }
		[XmlElement(ElementName = "timecompleted")]
		public string Timecompleted { get; set; }
		[XmlElement(ElementName = "reaggregate")]
		public string Reaggregate { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

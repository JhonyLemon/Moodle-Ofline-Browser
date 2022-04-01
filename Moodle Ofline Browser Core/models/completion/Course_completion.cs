using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.completion
{
	[XmlRoot(ElementName = "course_completion")]
	public class Course_completion
	{
		[XmlElement(ElementName = "course_completions")]
		public Course_completions Course_completions { get; set; }
	}
}

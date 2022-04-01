using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.gradebook
{
	[XmlRoot(ElementName = "grade_items")]
	public class Grade_items
	{
		[XmlElement(ElementName = "grade_item")]
		public Grade_item Grade_item { get; set; }
	}
}

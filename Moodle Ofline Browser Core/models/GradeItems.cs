using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "grade_items", Namespace = "")]
	public class GradeItems
	{

		[XmlElement(ElementName = "grade_item", Namespace = "")]
		public GradeItem GradeItem;
	}
}

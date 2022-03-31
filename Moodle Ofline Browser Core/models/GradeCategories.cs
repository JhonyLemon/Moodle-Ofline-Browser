using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "grade_categories", Namespace = "")]
	public class GradeCategories
	{

		[XmlElement(ElementName = "grade_category", Namespace = "")]
		public GradeCategory GradeCategory;
	}
}

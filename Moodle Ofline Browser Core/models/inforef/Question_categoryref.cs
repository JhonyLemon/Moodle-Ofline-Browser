using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.inforef
{
	[XmlRoot(ElementName = "question_categoryref")]
	public class Question_categoryref
	{
		[XmlElement(ElementName = "question_category")]
		public List<Question_category> Question_category { get; set; }
	}
}

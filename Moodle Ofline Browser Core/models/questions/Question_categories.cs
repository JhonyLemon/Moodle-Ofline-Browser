using HtmlParserSharp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.questions
{
	[XmlRoot(ElementName = "question_categories")]
	public class Question_categories
	{
		[XmlElement(ElementName = "question_category")]
		public List<Question_category> Question_category { get; set; }
	}
}

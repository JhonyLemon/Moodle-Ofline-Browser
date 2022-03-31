using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(QuestionCategories));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (QuestionCategories)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "question_categories", Namespace = "")]
	public class QuestionCategories
	{

		[XmlElement(ElementName = "question_category", Namespace = "")]
		public List<QuestionCategory> QuestionCategory;
	}


}

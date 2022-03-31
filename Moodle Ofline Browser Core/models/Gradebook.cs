using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(Gradebook));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (Gradebook)serializer.Deserialize(reader);
	// }
	[XmlRoot(ElementName = "gradebook", Namespace = "")]
	public class Gradebook
	{

		[XmlElement(ElementName = "attributes", Namespace = "")]
		public object Attributes;

		[XmlElement(ElementName = "grade_categories", Namespace = "")]
		public GradeCategories GradeCategories;

		[XmlElement(ElementName = "grade_items", Namespace = "")]
		public GradeItems GradeItems;

		[XmlElement(ElementName = "grade_letters", Namespace = "")]
		public object GradeLetters;

		[XmlElement(ElementName = "grade_settings", Namespace = "")]
		public GradeSettings GradeSettings;
	}


}

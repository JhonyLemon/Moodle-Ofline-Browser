using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "ddmarker", Namespace = "")]
	public class Ddmarker
	{

		[XmlElement(ElementName = "shuffleanswers", Namespace = "")]
		public int Shuffleanswers;

		[XmlElement(ElementName = "correctfeedback", Namespace = "")]
		public string Correctfeedback;

		[XmlElement(ElementName = "correctfeedbackformat", Namespace = "")]
		public int Correctfeedbackformat;

		[XmlElement(ElementName = "partiallycorrectfeedback", Namespace = "")]
		public string Partiallycorrectfeedback;

		[XmlElement(ElementName = "partiallycorrectfeedbackformat", Namespace = "")]
		public int Partiallycorrectfeedbackformat;

		[XmlElement(ElementName = "incorrectfeedback", Namespace = "")]
		public string Incorrectfeedback;

		[XmlElement(ElementName = "incorrectfeedbackformat", Namespace = "")]
		public int Incorrectfeedbackformat;

		[XmlElement(ElementName = "shownumcorrect", Namespace = "")]
		public int Shownumcorrect;

		[XmlElement(ElementName = "showmisplaced", Namespace = "")]
		public int Showmisplaced;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public int Id;

		[XmlText]
		public string Text;
	}
}

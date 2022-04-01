using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.questions
{
	[XmlRoot(ElementName = "ddmarker")]
	public class Ddmarker
	{
		[XmlElement(ElementName = "shuffleanswers")]
		public string Shuffleanswers { get; set; }
		[XmlElement(ElementName = "correctfeedback")]
		public string Correctfeedback { get; set; }
		[XmlElement(ElementName = "correctfeedbackformat")]
		public string Correctfeedbackformat { get; set; }
		[XmlElement(ElementName = "partiallycorrectfeedback")]
		public string Partiallycorrectfeedback { get; set; }
		[XmlElement(ElementName = "partiallycorrectfeedbackformat")]
		public string Partiallycorrectfeedbackformat { get; set; }
		[XmlElement(ElementName = "incorrectfeedback")]
		public string Incorrectfeedback { get; set; }
		[XmlElement(ElementName = "incorrectfeedbackformat")]
		public string Incorrectfeedbackformat { get; set; }
		[XmlElement(ElementName = "shownumcorrect")]
		public string Shownumcorrect { get; set; }
		[XmlElement(ElementName = "showmisplaced")]
		public string Showmisplaced { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.questions
{
	[XmlRoot(ElementName = "question")]
	public class Question
	{
		[XmlElement(ElementName = "parent")]
		public string Parent { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "questiontext")]
		public string Questiontext { get; set; }
		[XmlElement(ElementName = "questiontextformat")]
		public string Questiontextformat { get; set; }
		[XmlElement(ElementName = "generalfeedback")]
		public string Generalfeedback { get; set; }
		[XmlElement(ElementName = "generalfeedbackformat")]
		public string Generalfeedbackformat { get; set; }
		[XmlElement(ElementName = "defaultmark")]
		public string Defaultmark { get; set; }
		[XmlElement(ElementName = "penalty")]
		public string Penalty { get; set; }
		[XmlElement(ElementName = "qtype")]
		public string Qtype { get; set; }
		[XmlElement(ElementName = "length")]
		public string Length { get; set; }
		[XmlElement(ElementName = "stamp")]
		public string Stamp { get; set; }
		[XmlElement(ElementName = "version")]
		public string Version { get; set; }
		[XmlElement(ElementName = "hidden")]
		public string Hidden { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "createdby")]
		public string Createdby { get; set; }
		[XmlElement(ElementName = "modifiedby")]
		public string Modifiedby { get; set; }
		[XmlElement(ElementName = "idnumber")]
		public string Idnumber { get; set; }
		[XmlElement(ElementName = "plugin_qtype_ddmarker_question")]
		public Plugin_qtype_ddmarker_question Plugin_qtype_ddmarker_question { get; set; }
		[XmlElement(ElementName = "question_hints")]
		public string Question_hints { get; set; }
		[XmlElement(ElementName = "tags")]
		public string Tags { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "question", Namespace = "")]
	public class Question
	{

		[XmlElement(ElementName = "parent", Namespace = "")]
		public int Parent;

		[XmlElement(ElementName = "name", Namespace = "")]
		public string Name;

		[XmlElement(ElementName = "questiontext", Namespace = "")]
		public string Questiontext;

		[XmlElement(ElementName = "questiontextformat", Namespace = "")]
		public int Questiontextformat;

		[XmlElement(ElementName = "generalfeedback", Namespace = "")]
		public object Generalfeedback;

		[XmlElement(ElementName = "generalfeedbackformat", Namespace = "")]
		public int Generalfeedbackformat;

		[XmlElement(ElementName = "defaultmark", Namespace = "")]
		public double Defaultmark;

		[XmlElement(ElementName = "penalty", Namespace = "")]
		public double Penalty;

		[XmlElement(ElementName = "qtype", Namespace = "")]
		public string Qtype;

		[XmlElement(ElementName = "length", Namespace = "")]
		public int Length;

		[XmlElement(ElementName = "stamp", Namespace = "")]
		public string Stamp;

		[XmlElement(ElementName = "version", Namespace = "")]
		public string Version;

		[XmlElement(ElementName = "hidden", Namespace = "")]
		public int Hidden;

		[XmlElement(ElementName = "timecreated", Namespace = "")]
		public int Timecreated;

		[XmlElement(ElementName = "timemodified", Namespace = "")]
		public int Timemodified;

		[XmlElement(ElementName = "createdby", Namespace = "")]
		public int Createdby;

		[XmlElement(ElementName = "modifiedby", Namespace = "")]
		public int Modifiedby;

		[XmlElement(ElementName = "idnumber", Namespace = "")]
		public string Idnumber;

		[XmlElement(ElementName = "plugin_qtype_ddmarker_question", Namespace = "")]
		public PluginQtypeDdmarkerQuestion PluginQtypeDdmarkerQuestion;

		[XmlElement(ElementName = "question_hints", Namespace = "")]
		public object QuestionHints;

		[XmlElement(ElementName = "tags", Namespace = "")]
		public object Tags;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public int Id;

		[XmlText]
		public string Text;
	}
}

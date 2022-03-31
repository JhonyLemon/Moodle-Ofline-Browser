using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "question_category", Namespace = "")]
	public class QuestionCategory
	{

		[XmlElement(ElementName = "questions", Namespace = "")]
		public Questions Questions;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public int Id;

		[XmlText]
		public string Text;

		[XmlElement(ElementName = "name", Namespace = "")]
		public string Name;

		[XmlElement(ElementName = "contextid", Namespace = "")]
		public int Contextid;

		[XmlElement(ElementName = "contextlevel", Namespace = "")]
		public int Contextlevel;

		[XmlElement(ElementName = "contextinstanceid", Namespace = "")]
		public int Contextinstanceid;

		[XmlElement(ElementName = "info", Namespace = "")]
		public object Info;

		[XmlElement(ElementName = "infoformat", Namespace = "")]
		public int Infoformat;

		[XmlElement(ElementName = "stamp", Namespace = "")]
		public string Stamp;

		[XmlElement(ElementName = "parent", Namespace = "")]
		public int Parent;

		[XmlElement(ElementName = "sortorder", Namespace = "")]
		public int Sortorder;

		[XmlElement(ElementName = "idnumber", Namespace = "")]
		public string Idnumber;
	}
}

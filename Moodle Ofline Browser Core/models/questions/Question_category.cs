using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.questions
{
	[XmlRoot(ElementName = "question_category")]
	public class Question_category
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "contextid")]
		public string Contextid { get; set; }
		[XmlElement(ElementName = "contextlevel")]
		public string Contextlevel { get; set; }
		[XmlElement(ElementName = "contextinstanceid")]
		public string Contextinstanceid { get; set; }
		[XmlElement(ElementName = "info")]
		public string Info { get; set; }
		[XmlElement(ElementName = "infoformat")]
		public string Infoformat { get; set; }
		[XmlElement(ElementName = "stamp")]
		public string Stamp { get; set; }
		[XmlElement(ElementName = "parent")]
		public string Parent { get; set; }
		[XmlElement(ElementName = "sortorder")]
		public string Sortorder { get; set; }
		[XmlElement(ElementName = "idnumber")]
		public string Idnumber { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "questions")]
		public Questions Questions { get; set; }
	}
}

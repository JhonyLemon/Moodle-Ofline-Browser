using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.survey
{
	[XmlRoot(ElementName = "answer", Namespace = "survey")]
	public class Answer
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "question")]
		public string Question { get; set; }
		[XmlElement(ElementName = "time")]
		public string Time { get; set; }
		[XmlElement(ElementName = "answer1")]
		public string Answer1 { get; set; }
		[XmlElement(ElementName = "answer2")]
		public string Answer2 { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "answers", Namespace = "survey")]
	public class Answers
	{
		[XmlElement(ElementName = "answer", Namespace = "survey")]
		public List<Answer> Answer { get; set; }
	}

	[XmlRoot(ElementName = "survey")]
	public class Survey : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "template")]
		public string Template { get; set; }
		[XmlElement(ElementName = "questions")]
		public string Questions { get; set; }
		[XmlElement(ElementName = "days")]
		public string Days { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "completionsubmit")]
		public string Completionsubmit { get; set; }
		[XmlElement(ElementName = "answers", Namespace = "survey")]
		public Answers Answers { get; set; }
		[XmlElement(ElementName = "analysis")]
		public string Analysis { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

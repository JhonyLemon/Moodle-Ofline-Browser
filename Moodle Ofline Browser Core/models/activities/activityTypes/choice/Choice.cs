using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.choice
{
	[XmlRoot(ElementName = "choice")]
	public class Choice : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "publish")]
		public string Publish { get; set; }
		[XmlElement(ElementName = "showresults")]
		public string Showresults { get; set; }
		[XmlElement(ElementName = "display")]
		public string Display { get; set; }
		[XmlElement(ElementName = "allowupdate")]
		public string Allowupdate { get; set; }
		[XmlElement(ElementName = "allowmultiple")]
		public string Allowmultiple { get; set; }
		[XmlElement(ElementName = "showunanswered")]
		public string Showunanswered { get; set; }
		[XmlElement(ElementName = "limitanswers")]
		public string Limitanswers { get; set; }
		[XmlElement(ElementName = "timeopen")]
		public string Timeopen { get; set; }
		[XmlElement(ElementName = "timeclose")]
		public string Timeclose { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "completionsubmit")]
		public string Completionsubmit { get; set; }
		[XmlElement(ElementName = "showpreview")]
		public string Showpreview { get; set; }
		[XmlElement(ElementName = "includeinactive")]
		public string Includeinactive { get; set; }
		[XmlElement(ElementName = "showavailable")]
		public string Showavailable { get; set; }
		[XmlElement(ElementName = "options")]
		public Options Options { get; set; }
		[XmlElement(ElementName = "answers", Namespace = "choice")]
		public Answers Answers { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

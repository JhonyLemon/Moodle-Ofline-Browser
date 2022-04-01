using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.grade_history
{
	[XmlRoot(ElementName = "grade_grade")]
	public class Grade_grade
	{
		[XmlElement(ElementName = "action")]
		public string Action { get; set; }
		[XmlElement(ElementName = "oldid")]
		public string Oldid { get; set; }
		[XmlElement(ElementName = "source")]
		public string Source { get; set; }
		[XmlElement(ElementName = "loggeduser")]
		public string Loggeduser { get; set; }
		[XmlElement(ElementName = "itemid")]
		public string Itemid { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "rawgrade")]
		public string Rawgrade { get; set; }
		[XmlElement(ElementName = "rawgrademax")]
		public string Rawgrademax { get; set; }
		[XmlElement(ElementName = "rawgrademin")]
		public string Rawgrademin { get; set; }
		[XmlElement(ElementName = "rawscaleid")]
		public string Rawscaleid { get; set; }
		[XmlElement(ElementName = "usermodified")]
		public string Usermodified { get; set; }
		[XmlElement(ElementName = "finalgrade")]
		public string Finalgrade { get; set; }
		[XmlElement(ElementName = "hidden")]
		public string Hidden { get; set; }
		[XmlElement(ElementName = "locked")]
		public string Locked { get; set; }
		[XmlElement(ElementName = "locktime")]
		public string Locktime { get; set; }
		[XmlElement(ElementName = "exported")]
		public string Exported { get; set; }
		[XmlElement(ElementName = "overridden")]
		public string Overridden { get; set; }
		[XmlElement(ElementName = "excluded")]
		public string Excluded { get; set; }
		[XmlElement(ElementName = "feedback")]
		public string Feedback { get; set; }
		[XmlElement(ElementName = "feedbackformat")]
		public string Feedbackformat { get; set; }
		[XmlElement(ElementName = "information")]
		public string Information { get; set; }
		[XmlElement(ElementName = "informationformat")]
		public string Informationformat { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

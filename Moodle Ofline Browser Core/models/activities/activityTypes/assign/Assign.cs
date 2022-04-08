using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "assign")]
	public class Assign : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "alwaysshowdescription")]
		public string Alwaysshowdescription { get; set; }
		[XmlElement(ElementName = "submissiondrafts")]
		public string Submissiondrafts { get; set; }
		[XmlElement(ElementName = "sendnotifications")]
		public string Sendnotifications { get; set; }
		[XmlElement(ElementName = "sendlatenotifications")]
		public string Sendlatenotifications { get; set; }
		[XmlElement(ElementName = "sendstudentnotifications")]
		public string Sendstudentnotifications { get; set; }
		[XmlElement(ElementName = "duedate")]
		public string Duedate { get; set; }
		[XmlElement(ElementName = "cutoffdate")]
		public string Cutoffdate { get; set; }
		[XmlElement(ElementName = "gradingduedate")]
		public string Gradingduedate { get; set; }
		[XmlElement(ElementName = "allowsubmissionsfromdate")]
		public string Allowsubmissionsfromdate { get; set; }
		[XmlElement(ElementName = "grade")]
		public string Grade { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "completionsubmit")]
		public string Completionsubmit { get; set; }
		[XmlElement(ElementName = "requiresubmissionstatement")]
		public string Requiresubmissionstatement { get; set; }
		[XmlElement(ElementName = "teamsubmission")]
		public string Teamsubmission { get; set; }
		[XmlElement(ElementName = "requireallteammemberssubmit")]
		public string Requireallteammemberssubmit { get; set; }
		[XmlElement(ElementName = "teamsubmissiongroupingid")]
		public string Teamsubmissiongroupingid { get; set; }
		[XmlElement(ElementName = "blindmarking")]
		public string Blindmarking { get; set; }
		[XmlElement(ElementName = "hidegrader")]
		public string Hidegrader { get; set; }
		[XmlElement(ElementName = "revealidentities")]
		public string Revealidentities { get; set; }
		[XmlElement(ElementName = "attemptreopenmethod")]
		public string Attemptreopenmethod { get; set; }
		[XmlElement(ElementName = "maxattempts")]
		public string Maxattempts { get; set; }
		[XmlElement(ElementName = "markingworkflow")]
		public string Markingworkflow { get; set; }
		[XmlElement(ElementName = "markingallocation")]
		public string Markingallocation { get; set; }
		[XmlElement(ElementName = "preventsubmissionnotingroup")]
		public string Preventsubmissionnotingroup { get; set; }
		[XmlElement(ElementName = "userflags")]
		public string Userflags { get; set; }
		[XmlElement(ElementName = "submissions")]
		public Submissions Submissions { get; set; }
		[XmlElement(ElementName = "grades")]
		public Grades Grades { get; set; }
		[XmlElement(ElementName = "plugin_configs")]
		public Plugin_configs Plugin_configs { get; set; }
		[XmlElement(ElementName = "overrides")]
		public string Overrides { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "submission")]
	public class Submission
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "status")]
		public string Status { get; set; }
		[XmlElement(ElementName = "groupid")]
		public string Groupid { get; set; }
		[XmlElement(ElementName = "attemptnumber")]
		public string Attemptnumber { get; set; }
		[XmlElement(ElementName = "latest")]
		public string Latest { get; set; }
		[XmlElement(ElementName = "subplugin_assignsubmission_onlinetext_submission")]
		public string Subplugin_assignsubmission_onlinetext_submission { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "subplugin_assignsubmission_file_submission")]
		public Subplugin_assignsubmission_file_submission Subplugin_assignsubmission_file_submission { get; set; }
	}
}

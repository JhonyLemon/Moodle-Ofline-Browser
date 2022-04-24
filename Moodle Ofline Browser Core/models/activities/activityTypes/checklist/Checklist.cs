using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.checklist
{
	[XmlRoot(ElementName = "checklist")]
	public class Checklist : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "useritemsallowed")]
		public string Useritemsallowed { get; set; }
		[XmlElement(ElementName = "studentcomments")]
		public string Studentcomments { get; set; }
		[XmlElement(ElementName = "teacheredit")]
		public string Teacheredit { get; set; }
		[XmlElement(ElementName = "theme")]
		public string Theme { get; set; }
		[XmlElement(ElementName = "duedatesoncalendar")]
		public string Duedatesoncalendar { get; set; }
		[XmlElement(ElementName = "teachercomments")]
		public string Teachercomments { get; set; }
		[XmlElement(ElementName = "maxgrade")]
		public string Maxgrade { get; set; }
		[XmlElement(ElementName = "autopopulate")]
		public string Autopopulate { get; set; }
		[XmlElement(ElementName = "autoupdate")]
		public string Autoupdate { get; set; }
		[XmlElement(ElementName = "completionpercent")]
		public string Completionpercent { get; set; }
		[XmlElement(ElementName = "completionpercenttype")]
		public string Completionpercenttype { get; set; }
		[XmlElement(ElementName = "emailoncomplete")]
		public string Emailoncomplete { get; set; }
		[XmlElement(ElementName = "lockteachermarks")]
		public string Lockteachermarks { get; set; }
		[XmlElement(ElementName = "items")]
		public Items Items { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

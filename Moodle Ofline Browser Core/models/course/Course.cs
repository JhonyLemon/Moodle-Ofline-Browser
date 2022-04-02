using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.course
{
		[XmlRoot(ElementName = "course")]
		public class Course
		{
			[XmlElement(ElementName = "shortname")]
			public string Shortname { get; set; }
			[XmlElement(ElementName = "fullname")]
			public string Fullname { get; set; }
			[XmlElement(ElementName = "idnumber")]
			public string Idnumber { get; set; }
			[XmlElement(ElementName = "summary")]
			public string Summary { get; set; }
			[XmlElement(ElementName = "summaryformat")]
			public string Summaryformat { get; set; }
			[XmlElement(ElementName = "format")]
			public string Format { get; set; }
			[XmlElement(ElementName = "showgrades")]
			public string Showgrades { get; set; }
			[XmlElement(ElementName = "newsitems")]
			public string Newsitems { get; set; }
			[XmlElement(ElementName = "startdate")]
			public string Startdate { get; set; }
			[XmlElement(ElementName = "enddate")]
			public string Enddate { get; set; }
			[XmlElement(ElementName = "marker")]
			public string Marker { get; set; }
			[XmlElement(ElementName = "maxbytes")]
			public string Maxbytes { get; set; }
			[XmlElement(ElementName = "legacyfiles")]
			public string Legacyfiles { get; set; }
			[XmlElement(ElementName = "showreports")]
			public string Showreports { get; set; }
			[XmlElement(ElementName = "visible")]
			public string Visible { get; set; }
			[XmlElement(ElementName = "groupmode")]
			public string Groupmode { get; set; }
			[XmlElement(ElementName = "groupmodeforce")]
			public string Groupmodeforce { get; set; }
			[XmlElement(ElementName = "defaultgroupingid")]
			public string Defaultgroupingid { get; set; }
			[XmlElement(ElementName = "lang")]
			public string Lang { get; set; }
			[XmlElement(ElementName = "theme")]
			public string Theme { get; set; }
			[XmlElement(ElementName = "timecreated")]
			public string Timecreated { get; set; }
			[XmlElement(ElementName = "timemodified")]
			public string Timemodified { get; set; }
			[XmlElement(ElementName = "requested")]
			public string Requested { get; set; }
			[XmlElement(ElementName = "showactivitydates")]
			public string Showactivitydates { get; set; }
			[XmlElement(ElementName = "showcompletionconditions")]
			public string Showcompletionconditions { get; set; }
			[XmlElement(ElementName = "enablecompletion")]
			public string Enablecompletion { get; set; }
			[XmlElement(ElementName = "completionnotify")]
			public string Completionnotify { get; set; }
			[XmlElement(ElementName = "hiddensections")]
			public string Hiddensections { get; set; }
			[XmlElement(ElementName = "coursedisplay")]
			public string Coursedisplay { get; set; }
			[XmlElement(ElementName = "automaticenddate")]
			public string Automaticenddate { get; set; }
			[XmlElement(ElementName = "category")]
			public Category Category { get; set; }
			[XmlElement(ElementName = "tags")]
			public string Tags { get; set; }
			[XmlElement(ElementName = "customfields")]
			public string Customfields { get; set; }
			[XmlAttribute(AttributeName = "id")]
			public string Id { get; set; }
			[XmlAttribute(AttributeName = "contextid")]
			public string Contextid { get; set; }
		}
}

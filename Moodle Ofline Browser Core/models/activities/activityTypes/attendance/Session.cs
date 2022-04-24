using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance
{
	[XmlRoot(ElementName = "session")]
	public class Session
	{
		[XmlElement(ElementName = "groupid")]
		public string Groupid { get; set; }
		[XmlElement(ElementName = "sessdate")]
		public string Sessdate { get; set; }
		[XmlElement(ElementName = "duration")]
		public string Duration { get; set; }
		[XmlElement(ElementName = "lasttaken")]
		public string Lasttaken { get; set; }
		[XmlElement(ElementName = "lasttakenby")]
		public string Lasttakenby { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "descriptionformat")]
		public string Descriptionformat { get; set; }
		[XmlElement(ElementName = "studentscanmark")]
		public string Studentscanmark { get; set; }
		[XmlElement(ElementName = "studentpassword")]
		public string Studentpassword { get; set; }
		[XmlElement(ElementName = "autoassignstatus")]
		public string Autoassignstatus { get; set; }
		[XmlElement(ElementName = "subnet")]
		public string Subnet { get; set; }
		[XmlElement(ElementName = "automark")]
		public string Automark { get; set; }
		[XmlElement(ElementName = "automarkcompleted")]
		public string Automarkcompleted { get; set; }
		[XmlElement(ElementName = "statusset")]
		public string Statusset { get; set; }
		[XmlElement(ElementName = "absenteereport")]
		public string Absenteereport { get; set; }
		[XmlElement(ElementName = "preventsharedip")]
		public string Preventsharedip { get; set; }
		[XmlElement(ElementName = "preventsharediptime")]
		public string Preventsharediptime { get; set; }
		[XmlElement(ElementName = "caleventid")]
		public string Caleventid { get; set; }
		[XmlElement(ElementName = "calendarevent")]
		public string Calendarevent { get; set; }
		[XmlElement(ElementName = "includeqrcode")]
		public string Includeqrcode { get; set; }
		[XmlElement(ElementName = "automarkcmid")]
		public string Automarkcmid { get; set; }
		[XmlElement(ElementName = "logs", Namespace = "attendance")]
		public Logs Logs { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

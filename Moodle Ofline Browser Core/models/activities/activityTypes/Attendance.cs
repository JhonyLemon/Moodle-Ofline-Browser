using Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes
{
		[XmlRoot(ElementName = "attendance")]
		public class Attendance: ActivityType
		{
			[XmlElement(ElementName = "name")]
			public string Name { get; set; }
			[XmlElement(ElementName = "intro")]
			public string Intro { get; set; }
			[XmlElement(ElementName = "introformat")]
			public string Introformat { get; set; }
			[XmlElement(ElementName = "grade")]
			public string Grade { get; set; }
			[XmlElement(ElementName = "showextrauserdetails")]
			public string Showextrauserdetails { get; set; }
			[XmlElement(ElementName = "showsessiondetails")]
			public string Showsessiondetails { get; set; }
			[XmlElement(ElementName = "sessiondetailspos")]
			public string Sessiondetailspos { get; set; }
			[XmlElement(ElementName = "subnet")]
			public string Subnet { get; set; }
			[XmlElement(ElementName = "statuses")]
			public Statuses Statuses { get; set; }
			[XmlElement(ElementName = "warnings")]
			public string Warnings { get; set; }
			[XmlElement(ElementName = "sessions")]
			public Sessions Sessions { get; set; }
			[XmlAttribute(AttributeName = "id")]
			public string Id { get; set; }
		}
}

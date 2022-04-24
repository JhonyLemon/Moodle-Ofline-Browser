using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.checklist
{
	[XmlRoot(ElementName = "check")]
	public class Check
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "usertimestamp")]
		public string Usertimestamp { get; set; }
		[XmlElement(ElementName = "teachermark")]
		public string Teachermark { get; set; }
		[XmlElement(ElementName = "teachertimestamp")]
		public string Teachertimestamp { get; set; }
		[XmlElement(ElementName = "teacherid")]
		public string Teacherid { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

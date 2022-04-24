using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.customcert
{
	[XmlRoot(ElementName = "issue")]
	public class Issue
	{
		[XmlElement(ElementName = "customcertid")]
		public string Customcertid { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "emailed")]
		public string Emailed { get; set; }
		[XmlElement(ElementName = "code")]
		public string Code { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

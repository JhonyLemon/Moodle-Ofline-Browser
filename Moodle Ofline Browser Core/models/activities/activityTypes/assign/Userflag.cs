using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "userflag")]
	public class Userflag
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "assignment")]
		public string Assignment { get; set; }
		[XmlElement(ElementName = "mailed")]
		public string Mailed { get; set; }
		[XmlElement(ElementName = "locked")]
		public string Locked { get; set; }
		[XmlElement(ElementName = "extensionduedate")]
		public string Extensionduedate { get; set; }
		[XmlElement(ElementName = "workflowstate")]
		public string Workflowstate { get; set; }
		[XmlElement(ElementName = "allocatedmarker")]
		public string Allocatedmarker { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

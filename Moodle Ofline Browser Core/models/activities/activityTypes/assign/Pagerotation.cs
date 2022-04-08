using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "pagerotation")]
	public class Pagerotation
	{
		[XmlElement(ElementName = "gradeid")]
		public string Gradeid { get; set; }
		[XmlElement(ElementName = "pageno")]
		public string Pageno { get; set; }
		[XmlElement(ElementName = "pathnamehash")]
		public string Pathnamehash { get; set; }
		[XmlElement(ElementName = "isrotated")]
		public string Isrotated { get; set; }
		[XmlElement(ElementName = "degree")]
		public string Degree { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "submission_file")]
	public class Submission_file
	{
		[XmlElement(ElementName = "numfiles")]
		public string Numfiles { get; set; }
		[XmlElement(ElementName = "submission")]
		public string Submission { get; set; }
	}
}

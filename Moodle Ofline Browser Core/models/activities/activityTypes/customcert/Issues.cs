using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.customcert
{
	[XmlRoot(ElementName = "issues")]
	public class Issues
	{
		[XmlElement(ElementName = "issue")]
		public Issue Issue { get; set; }
	}
}

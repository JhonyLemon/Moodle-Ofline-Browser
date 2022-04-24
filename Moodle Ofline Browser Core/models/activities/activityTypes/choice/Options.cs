using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.choice
{
	[XmlRoot(ElementName = "options")]
	public class Options
	{
		[XmlElement(ElementName = "option")]
		public List<Option> Option { get; set; }
	}
}

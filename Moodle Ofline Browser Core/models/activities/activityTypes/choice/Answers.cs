using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.choice
{
	[XmlRoot(ElementName = "answers", Namespace = "choice")]
	public class Answers
	{
		[XmlElement(ElementName = "answer", Namespace = "choice")]
		public List<Answer> Answer { get; set; }
	}
}

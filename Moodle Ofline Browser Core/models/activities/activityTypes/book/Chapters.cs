using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.book
{

	[XmlRoot(ElementName = "chapters")]
	public class Chapters
	{
		[XmlElement(ElementName = "chapter")]
		public Chapter Chapter { get; set; }
	}
}

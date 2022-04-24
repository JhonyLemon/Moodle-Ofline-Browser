using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.chat
{

	[XmlRoot(ElementName = "messages")]
	public class Messages
	{
		[XmlElement(ElementName = "message")]
		public List<Message> Message { get; set; }
	}
}

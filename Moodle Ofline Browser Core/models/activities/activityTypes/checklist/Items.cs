using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.checklist
{
	[XmlRoot(ElementName = "items")]
	public class Items
	{
		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}
}

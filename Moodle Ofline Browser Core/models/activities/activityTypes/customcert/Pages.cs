
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.customcert
{
	[XmlRoot(ElementName = "pages", Namespace = "customcert")]
	public class Pages
	{
		[XmlElement(ElementName = "page", Namespace = "customcert")]
		public Page Page { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "details", Namespace = "")]
	public class Details
	{

		[XmlElement(ElementName = "detail", Namespace = "")]
		public Detail Detail;
	}
}

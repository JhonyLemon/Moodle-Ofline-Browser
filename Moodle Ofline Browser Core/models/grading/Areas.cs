using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.grading
{
		[XmlRoot(ElementName = "areas")]
		public class Areas
		{
			[XmlElement(ElementName = "area")]
			public Area Area { get; set; }
		}
}

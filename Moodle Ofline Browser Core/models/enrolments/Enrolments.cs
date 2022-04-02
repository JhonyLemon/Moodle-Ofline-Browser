using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.enrolments
{
		[XmlRoot(ElementName = "enrolments")]
		public class Enrolments
		{
			[XmlElement(ElementName = "enrols")]
			public Enrols Enrols { get; set; }
		}
}

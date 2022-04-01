using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.moodle_backup
{
		[XmlRoot(ElementName = "moodle_backup")]
		public class Moodle_backup
		{
			[XmlElement(ElementName = "information")]
			public Information Information { get; set; }
		}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.moodle_backup
{
	[XmlRoot(ElementName = "detail")]
	public class Detail
	{
		[XmlElement(ElementName = "type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "format")]
		public string Format { get; set; }
		[XmlElement(ElementName = "interactive")]
		public string Interactive { get; set; }
		[XmlElement(ElementName = "mode")]
		public string Mode { get; set; }
		[XmlElement(ElementName = "execution")]
		public string Execution { get; set; }
		[XmlElement(ElementName = "executiontime")]
		public string Executiontime { get; set; }
		[XmlAttribute(AttributeName = "backup_id")]
		public string Backup_id { get; set; }
	}
}

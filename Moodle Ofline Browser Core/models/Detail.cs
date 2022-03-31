using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "detail", Namespace = "")]
	public class Detail
	{

		[XmlElement(ElementName = "type", Namespace = "")]
		public string Type;

		[XmlElement(ElementName = "format", Namespace = "")]
		public string Format;

		[XmlElement(ElementName = "interactive", Namespace = "")]
		public int Interactive;

		[XmlElement(ElementName = "mode", Namespace = "")]
		public int Mode;

		[XmlElement(ElementName = "execution", Namespace = "")]
		public int Execution;

		[XmlElement(ElementName = "executiontime", Namespace = "")]
		public int Executiontime;

		[XmlAttribute(AttributeName = "backup_id", Namespace = "")]
		public string BackupId;

		[XmlText]
		public string Text;
	}
}

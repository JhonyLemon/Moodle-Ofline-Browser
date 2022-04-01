using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.files
{
	[XmlRoot(ElementName = "files")]
	public class Files
	{
		[XmlElement(ElementName = "file")]
		public List<File> File { get; set; }
	}
}

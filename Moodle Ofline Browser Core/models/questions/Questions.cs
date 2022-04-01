using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.questions
{









	[XmlRoot(ElementName = "questions")]
	public class Questions
	{
		[XmlElement(ElementName = "question")]
		public Question Question { get; set; }
	}





}

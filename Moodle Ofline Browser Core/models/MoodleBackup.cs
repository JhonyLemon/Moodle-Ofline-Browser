using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(MoodleBackup));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (MoodleBackup)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "moodle_backup", Namespace = "")]
	public class MoodleBackup
	{

		[XmlElement(ElementName = "information", Namespace = "")]
		public Information Information;
	}


}

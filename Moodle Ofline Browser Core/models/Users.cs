using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "users", Namespace = "")]
	class Users
    {
		// using System.Xml.Serialization;
		// XmlSerializer serializer = new XmlSerializer(typeof(Users));
		// using (StringReader reader = new StringReader(xml))
		// {
		//    var test = (Users)serializer.Deserialize(reader);
		// }

		[XmlElement(ElementName = "user", Namespace = "")]
		public List<User> User;
		


	}
}

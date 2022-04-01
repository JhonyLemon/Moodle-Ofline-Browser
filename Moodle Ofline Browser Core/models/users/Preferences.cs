using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.users
{
    [XmlRoot(ElementName = "preferences")]
    public class Preferences
    {
        [XmlElement(ElementName = "preference")]
        public List<Preference> Preference { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.logstores
{
	[XmlRoot(ElementName = "logstore_standard_log")]
	public class Logstore_standard_log
	{
		[XmlElement(ElementName = "eventname")]
		public string Eventname { get; set; }
		[XmlElement(ElementName = "component")]
		public string Component { get; set; }
		[XmlElement(ElementName = "action")]
		public string Action { get; set; }
		[XmlElement(ElementName = "target")]
		public string Target { get; set; }
		[XmlElement(ElementName = "objecttable")]
		public string Objecttable { get; set; }
		[XmlElement(ElementName = "objectid")]
		public string Objectid { get; set; }
		[XmlElement(ElementName = "crud")]
		public string Crud { get; set; }
		[XmlElement(ElementName = "edulevel")]
		public string Edulevel { get; set; }
		[XmlElement(ElementName = "contextid")]
		public string Contextid { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "relateduserid")]
		public string Relateduserid { get; set; }
		[XmlElement(ElementName = "anonymous")]
		public string Anonymous { get; set; }
		[XmlElement(ElementName = "other")]
		public string Other { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "ip")]
		public string Ip { get; set; }
		[XmlElement(ElementName = "realuserid")]
		public string Realuserid { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

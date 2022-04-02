using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.module
{
		[XmlRoot(ElementName = "module")]
		public class Module
		{
			[XmlElement(ElementName = "modulename")]
			public string Modulename { get; set; }
			[XmlElement(ElementName = "sectionid")]
			public string Sectionid { get; set; }
			[XmlElement(ElementName = "sectionnumber")]
			public string Sectionnumber { get; set; }
			[XmlElement(ElementName = "idnumber")]
			public string Idnumber { get; set; }
			[XmlElement(ElementName = "added")]
			public string Added { get; set; }
			[XmlElement(ElementName = "score")]
			public string Score { get; set; }
			[XmlElement(ElementName = "indent")]
			public string Indent { get; set; }
			[XmlElement(ElementName = "visible")]
			public string Visible { get; set; }
			[XmlElement(ElementName = "visibleoncoursepage")]
			public string Visibleoncoursepage { get; set; }
			[XmlElement(ElementName = "visibleold")]
			public string Visibleold { get; set; }
			[XmlElement(ElementName = "groupmode")]
			public string Groupmode { get; set; }
			[XmlElement(ElementName = "groupingid")]
			public string Groupingid { get; set; }
			[XmlElement(ElementName = "completion")]
			public string Completion { get; set; }
			[XmlElement(ElementName = "completiongradeitemnumber")]
			public string Completiongradeitemnumber { get; set; }
			[XmlElement(ElementName = "completionview")]
			public string Completionview { get; set; }
			[XmlElement(ElementName = "completionexpected")]
			public string Completionexpected { get; set; }
			[XmlElement(ElementName = "availability")]
			public string Availability { get; set; }
			[XmlElement(ElementName = "showdescription")]
			public string Showdescription { get; set; }
			[XmlElement(ElementName = "tags")]
			public string Tags { get; set; }
			[XmlAttribute(AttributeName = "id")]
			public string Id { get; set; }
			[XmlAttribute(AttributeName = "version")]
			public string Version { get; set; }
		}
}

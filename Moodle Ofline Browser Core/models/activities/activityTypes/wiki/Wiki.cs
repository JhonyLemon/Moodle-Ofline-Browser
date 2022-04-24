using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.wiki
{
	[XmlRoot(ElementName = "version")]
	public class Version
	{
		[XmlElement(ElementName = "content")]
		public string Content { get; set; }
		[XmlElement(ElementName = "contentformat")]
		public string Contentformat { get; set; }
		[XmlElement(ElementName = "version")]
		public string _Version { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "versions")]
	public class Versions
	{
		[XmlElement(ElementName = "version")]
		public List<Version> Version { get; set; }
	}

	[XmlRoot(ElementName = "page", Namespace = "wiki")]
	public class Page
	{
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "cachedcontent")]
		public string Cachedcontent { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "timerendered")]
		public string Timerendered { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "pageviews")]
		public string Pageviews { get; set; }
		[XmlElement(ElementName = "readonly")]
		public string Readonly { get; set; }
		[XmlElement(ElementName = "versions")]
		public Versions Versions { get; set; }
		[XmlElement(ElementName = "tags")]
		public string Tags { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "pages", Namespace = "wiki")]
	public class Pages
	{
		[XmlElement(ElementName = "page", Namespace = "wiki")]
		public Page Page { get; set; }
	}

	[XmlRoot(ElementName = "subwiki")]
	public class Subwiki
	{
		[XmlElement(ElementName = "groupid")]
		public string Groupid { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "pages", Namespace = "wiki")]
		public Pages Pages { get; set; }
		[XmlElement(ElementName = "synonyms")]
		public string Synonyms { get; set; }
		[XmlElement(ElementName = "links")]
		public string Links { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "subwikis")]
	public class Subwikis
	{
		[XmlElement(ElementName = "subwiki")]
		public Subwiki Subwiki { get; set; }
	}

	[XmlRoot(ElementName = "wiki")]
	public class Wiki : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "firstpagetitle")]
		public string Firstpagetitle { get; set; }
		[XmlElement(ElementName = "wikimode")]
		public string Wikimode { get; set; }
		[XmlElement(ElementName = "defaultformat")]
		public string Defaultformat { get; set; }
		[XmlElement(ElementName = "forceformat")]
		public string Forceformat { get; set; }
		[XmlElement(ElementName = "editbegin")]
		public string Editbegin { get; set; }
		[XmlElement(ElementName = "editend")]
		public string Editend { get; set; }
		[XmlElement(ElementName = "subwikis")]
		public Subwikis Subwikis { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.badges
{
	[XmlRoot(ElementName = "badge")]
	public class Badge
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "usercreated")]
		public string Usercreated { get; set; }
		[XmlElement(ElementName = "usermodified")]
		public string Usermodified { get; set; }
		[XmlElement(ElementName = "issuername")]
		public string Issuername { get; set; }
		[XmlElement(ElementName = "issuerurl")]
		public string Issuerurl { get; set; }
		[XmlElement(ElementName = "issuercontact")]
		public string Issuercontact { get; set; }
		[XmlElement(ElementName = "expiredate")]
		public string Expiredate { get; set; }
		[XmlElement(ElementName = "expireperiod")]
		public string Expireperiod { get; set; }
		[XmlElement(ElementName = "type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "courseid")]
		public string Courseid { get; set; }
		[XmlElement(ElementName = "message")]
		public string Message { get; set; }
		[XmlElement(ElementName = "messagesubject")]
		public string Messagesubject { get; set; }
		[XmlElement(ElementName = "attachment")]
		public string Attachment { get; set; }
		[XmlElement(ElementName = "notification")]
		public string Notification { get; set; }
		[XmlElement(ElementName = "status")]
		public string Status { get; set; }
		[XmlElement(ElementName = "nextcron")]
		public string Nextcron { get; set; }
		[XmlElement(ElementName = "version")]
		public string Version { get; set; }
		[XmlElement(ElementName = "language")]
		public string Language { get; set; }
		[XmlElement(ElementName = "imageauthorname")]
		public string Imageauthorname { get; set; }
		[XmlElement(ElementName = "imageauthoremail")]
		public string Imageauthoremail { get; set; }
		[XmlElement(ElementName = "imageauthorurl")]
		public string Imageauthorurl { get; set; }
		[XmlElement(ElementName = "imagecaption")]
		public string Imagecaption { get; set; }
		[XmlElement(ElementName = "criteria")]
		public Criteria Criteria { get; set; }
		[XmlElement(ElementName = "alignments")]
		public string Alignments { get; set; }
		[XmlElement(ElementName = "relatedbadges")]
		public string Relatedbadges { get; set; }
		[XmlElement(ElementName = "manual_awards")]
		public string Manual_awards { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

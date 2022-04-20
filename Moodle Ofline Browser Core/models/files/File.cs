﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.files
{
	[XmlRoot(ElementName = "file")]
	public class File
	{
		[XmlElement(ElementName = "contenthash")]
		public string Contenthash { get; set; }
		[XmlElement(ElementName = "contextid")]
		public string Contextid { get; set; }
		[XmlElement(ElementName = "component")]
		public string Component { get; set; }
		[XmlElement(ElementName = "filearea")]
		public string Filearea { get; set; }
		[XmlElement(ElementName = "itemid")]
		public string Itemid { get; set; }
		[XmlElement(ElementName = "filepath")]
		public string Filepath { get; set; }
		[XmlElement(ElementName = "filename")]
		public string Filename { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "filesize")]
		public string Filesize { get; set; }
		[XmlElement(ElementName = "mimetype")]
		public string Mimetype { get; set; }
		[XmlElement(ElementName = "status")]
		public string Status { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public long Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public long Timemodified { get; set; }
		[XmlElement(ElementName = "source")]
		public string Source { get; set; }
		[XmlElement(ElementName = "author")]
		public string Author { get; set; }
		[XmlElement(ElementName = "license")]
		public string License { get; set; }
		[XmlElement(ElementName = "sortorder")]
		public string Sortorder { get; set; }
		[XmlElement(ElementName = "repositorytype")]
		public string Repositorytype { get; set; }
		[XmlElement(ElementName = "repositoryid")]
		public string Repositoryid { get; set; }
		[XmlElement(ElementName = "reference")]
		public string Reference { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

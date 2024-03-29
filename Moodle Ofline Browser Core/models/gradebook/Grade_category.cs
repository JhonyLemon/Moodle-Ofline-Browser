﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.gradebook
{
	[XmlRoot(ElementName = "grade_category")]
	public class Grade_category
	{
		[XmlElement(ElementName = "parent")]
		public string Parent { get; set; }
		[XmlElement(ElementName = "depth")]
		public string Depth { get; set; }
		[XmlElement(ElementName = "path")]
		public string Path { get; set; }
		[XmlElement(ElementName = "fullname")]
		public string Fullname { get; set; }
		[XmlElement(ElementName = "aggregation")]
		public string Aggregation { get; set; }
		[XmlElement(ElementName = "keephigh")]
		public string Keephigh { get; set; }
		[XmlElement(ElementName = "droplow")]
		public string Droplow { get; set; }
		[XmlElement(ElementName = "aggregateonlygraded")]
		public string Aggregateonlygraded { get; set; }
		[XmlElement(ElementName = "aggregateoutcomes")]
		public string Aggregateoutcomes { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "hidden")]
		public string Hidden { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.gradebook
{
	[XmlRoot(ElementName = "grade_item")]
	public class Grade_item
	{
		[XmlElement(ElementName = "categoryid")]
		public string Categoryid { get; set; }
		[XmlElement(ElementName = "itemname")]
		public string Itemname { get; set; }
		[XmlElement(ElementName = "itemtype")]
		public string Itemtype { get; set; }
		[XmlElement(ElementName = "itemmodule")]
		public string Itemmodule { get; set; }
		[XmlElement(ElementName = "iteminstance")]
		public string Iteminstance { get; set; }
		[XmlElement(ElementName = "itemnumber")]
		public string Itemnumber { get; set; }
		[XmlElement(ElementName = "iteminfo")]
		public string Iteminfo { get; set; }
		[XmlElement(ElementName = "idnumber")]
		public string Idnumber { get; set; }
		[XmlElement(ElementName = "calculation")]
		public string Calculation { get; set; }
		[XmlElement(ElementName = "gradetype")]
		public string Gradetype { get; set; }
		[XmlElement(ElementName = "grademax")]
		public string Grademax { get; set; }
		[XmlElement(ElementName = "grademin")]
		public string Grademin { get; set; }
		[XmlElement(ElementName = "scaleid")]
		public string Scaleid { get; set; }
		[XmlElement(ElementName = "outcomeid")]
		public string Outcomeid { get; set; }
		[XmlElement(ElementName = "gradepass")]
		public string Gradepass { get; set; }
		[XmlElement(ElementName = "multfactor")]
		public string Multfactor { get; set; }
		[XmlElement(ElementName = "plusfactor")]
		public string Plusfactor { get; set; }
		[XmlElement(ElementName = "aggregationcoef")]
		public string Aggregationcoef { get; set; }
		[XmlElement(ElementName = "aggregationcoef2")]
		public string Aggregationcoef2 { get; set; }
		[XmlElement(ElementName = "weightoverride")]
		public string Weightoverride { get; set; }
		[XmlElement(ElementName = "sortorder")]
		public string Sortorder { get; set; }
		[XmlElement(ElementName = "display")]
		public string Display { get; set; }
		[XmlElement(ElementName = "decimals")]
		public string Decimals { get; set; }
		[XmlElement(ElementName = "hidden")]
		public string Hidden { get; set; }
		[XmlElement(ElementName = "locked")]
		public string Locked { get; set; }
		[XmlElement(ElementName = "locktime")]
		public string Locktime { get; set; }
		[XmlElement(ElementName = "needsupdate")]
		public string Needsupdate { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "grade_grades")]
		public Grade_grades Grade_grades { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

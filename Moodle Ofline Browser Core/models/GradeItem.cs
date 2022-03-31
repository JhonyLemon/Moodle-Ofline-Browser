using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "grade_item", Namespace = "")]
	public class GradeItem
	{

		[XmlElement(ElementName = "categoryid", Namespace = "")]
		public string Categoryid;

		[XmlElement(ElementName = "itemname", Namespace = "")]
		public string Itemname;

		[XmlElement(ElementName = "itemtype", Namespace = "")]
		public string Itemtype;

		[XmlElement(ElementName = "itemmodule", Namespace = "")]
		public string Itemmodule;

		[XmlElement(ElementName = "iteminstance", Namespace = "")]
		public int Iteminstance;

		[XmlElement(ElementName = "itemnumber", Namespace = "")]
		public string Itemnumber;

		[XmlElement(ElementName = "iteminfo", Namespace = "")]
		public string Iteminfo;

		[XmlElement(ElementName = "idnumber", Namespace = "")]
		public string Idnumber;

		[XmlElement(ElementName = "calculation", Namespace = "")]
		public string Calculation;

		[XmlElement(ElementName = "gradetype", Namespace = "")]
		public int Gradetype;

		[XmlElement(ElementName = "grademax", Namespace = "")]
		public double Grademax;

		[XmlElement(ElementName = "grademin", Namespace = "")]
		public double Grademin;

		[XmlElement(ElementName = "scaleid", Namespace = "")]
		public string Scaleid;

		[XmlElement(ElementName = "outcomeid", Namespace = "")]
		public string Outcomeid;

		[XmlElement(ElementName = "gradepass", Namespace = "")]
		public double Gradepass;

		[XmlElement(ElementName = "multfactor", Namespace = "")]
		public double Multfactor;

		[XmlElement(ElementName = "plusfactor", Namespace = "")]
		public double Plusfactor;

		[XmlElement(ElementName = "aggregationcoef", Namespace = "")]
		public double Aggregationcoef;

		[XmlElement(ElementName = "aggregationcoef2", Namespace = "")]
		public double Aggregationcoef2;

		[XmlElement(ElementName = "weightoverride", Namespace = "")]
		public int Weightoverride;

		[XmlElement(ElementName = "sortorder", Namespace = "")]
		public int Sortorder;

		[XmlElement(ElementName = "display", Namespace = "")]
		public int Display;

		[XmlElement(ElementName = "decimals", Namespace = "")]
		public string Decimals;

		[XmlElement(ElementName = "hidden", Namespace = "")]
		public int Hidden;

		[XmlElement(ElementName = "locked", Namespace = "")]
		public int Locked;

		[XmlElement(ElementName = "locktime", Namespace = "")]
		public int Locktime;

		[XmlElement(ElementName = "needsupdate", Namespace = "")]
		public int Needsupdate;

		[XmlElement(ElementName = "timecreated", Namespace = "")]
		public int Timecreated;

		[XmlElement(ElementName = "timemodified", Namespace = "")]
		public int Timemodified;

		[XmlElement(ElementName = "grade_grades", Namespace = "")]
		public GradeGrades GradeGrades;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public int Id;

		[XmlText]
		public string Text;
	}
}

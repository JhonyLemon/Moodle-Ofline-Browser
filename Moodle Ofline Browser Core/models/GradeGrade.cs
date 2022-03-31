using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "grade_grade", Namespace = "")]
	public class GradeGrade
	{

		[XmlElement(ElementName = "userid", Namespace = "")]
		public int Userid;

		[XmlElement(ElementName = "rawgrade", Namespace = "")]
		public string Rawgrade;

		[XmlElement(ElementName = "rawgrademax", Namespace = "")]
		public double Rawgrademax;

		[XmlElement(ElementName = "rawgrademin", Namespace = "")]
		public double Rawgrademin;

		[XmlElement(ElementName = "rawscaleid", Namespace = "")]
		public string Rawscaleid;

		[XmlElement(ElementName = "usermodified", Namespace = "")]
		public string Usermodified;

		[XmlElement(ElementName = "finalgrade", Namespace = "")]
		public double Finalgrade;

		[XmlElement(ElementName = "hidden", Namespace = "")]
		public int Hidden;

		[XmlElement(ElementName = "locked", Namespace = "")]
		public int Locked;

		[XmlElement(ElementName = "locktime", Namespace = "")]
		public int Locktime;

		[XmlElement(ElementName = "exported", Namespace = "")]
		public int Exported;

		[XmlElement(ElementName = "overridden", Namespace = "")]
		public int Overridden;

		[XmlElement(ElementName = "excluded", Namespace = "")]
		public int Excluded;

		[XmlElement(ElementName = "feedback", Namespace = "")]
		public string Feedback;

		[XmlElement(ElementName = "feedbackformat", Namespace = "")]
		public int Feedbackformat;

		[XmlElement(ElementName = "information", Namespace = "")]
		public string Information;

		[XmlElement(ElementName = "informationformat", Namespace = "")]
		public int Informationformat;

		[XmlElement(ElementName = "timecreated", Namespace = "")]
		public string Timecreated;

		[XmlElement(ElementName = "timemodified", Namespace = "")]
		public int Timemodified;

		[XmlElement(ElementName = "aggregationstatus", Namespace = "")]
		public string Aggregationstatus;

		[XmlElement(ElementName = "aggregationweight", Namespace = "")]
		public string Aggregationweight;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public int Id;

		[XmlText]
		public string Text;
	}
}

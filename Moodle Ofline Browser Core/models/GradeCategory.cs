using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "grade_category", Namespace = "")]
	public class GradeCategory
	{

		[XmlElement(ElementName = "parent", Namespace = "")]
		public string Parent;

		[XmlElement(ElementName = "depth", Namespace = "")]
		public int Depth;

		[XmlElement(ElementName = "path", Namespace = "")]
		public string Path;

		[XmlElement(ElementName = "fullname", Namespace = "")]
		public string Fullname;

		[XmlElement(ElementName = "aggregation", Namespace = "")]
		public int Aggregation;

		[XmlElement(ElementName = "keephigh", Namespace = "")]
		public int Keephigh;

		[XmlElement(ElementName = "droplow", Namespace = "")]
		public int Droplow;

		[XmlElement(ElementName = "aggregateonlygraded", Namespace = "")]
		public int Aggregateonlygraded;

		[XmlElement(ElementName = "aggregateoutcomes", Namespace = "")]
		public int Aggregateoutcomes;

		[XmlElement(ElementName = "timecreated", Namespace = "")]
		public int Timecreated;

		[XmlElement(ElementName = "timemodified", Namespace = "")]
		public int Timemodified;

		[XmlElement(ElementName = "hidden", Namespace = "")]
		public int Hidden;

		[XmlAttribute(AttributeName = "id", Namespace = "")]
		public int Id;

		[XmlText]
		public string Text;
	}
}

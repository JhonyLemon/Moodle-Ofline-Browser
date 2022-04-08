using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign
{
	[XmlRoot(ElementName = "subplugin_assignsubmission_file_submission")]
	public class Subplugin_assignsubmission_file_submission
	{
		[XmlElement(ElementName = "submission_file")]
		public Submission_file Submission_file { get; set; }
	}
}

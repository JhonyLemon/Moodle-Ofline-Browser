using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models
{
	[XmlRoot(ElementName = "information", Namespace = "")]
	public class Information
	{

		[XmlElement(ElementName = "name", Namespace = "")]
		public string Name;

		[XmlElement(ElementName = "moodle_version", Namespace = "")]
		public int MoodleVersion;

		[XmlElement(ElementName = "moodle_release", Namespace = "")]
		public string MoodleRelease;

		[XmlElement(ElementName = "backup_version", Namespace = "")]
		public int BackupVersion;

		[XmlElement(ElementName = "backup_release", Namespace = "")]
		public DateTime BackupRelease;

		[XmlElement(ElementName = "backup_date", Namespace = "")]
		public int BackupDate;

		[XmlElement(ElementName = "mnet_remoteusers", Namespace = "")]
		public int MnetRemoteusers;

		[XmlElement(ElementName = "include_files", Namespace = "")]
		public int IncludeFiles;

		[XmlElement(ElementName = "include_file_references_to_external_content", Namespace = "")]
		public int IncludeFileReferencesToExternalContent;

		[XmlElement(ElementName = "original_wwwroot", Namespace = "")]
		public string OriginalWwwroot;

		[XmlElement(ElementName = "original_site_identifier_hash", Namespace = "")]
		public string OriginalSiteIdentifierHash;

		[XmlElement(ElementName = "original_course_id", Namespace = "")]
		public int OriginalCourseId;

		[XmlElement(ElementName = "original_course_format", Namespace = "")]
		public string OriginalCourseFormat;

		[XmlElement(ElementName = "original_course_fullname", Namespace = "")]
		public string OriginalCourseFullname;

		[XmlElement(ElementName = "original_course_shortname", Namespace = "")]
		public string OriginalCourseShortname;

		[XmlElement(ElementName = "original_course_startdate", Namespace = "")]
		public int OriginalCourseStartdate;

		[XmlElement(ElementName = "original_course_enddate", Namespace = "")]
		public int OriginalCourseEnddate;

		[XmlElement(ElementName = "original_course_contextid", Namespace = "")]
		public int OriginalCourseContextid;

		[XmlElement(ElementName = "original_system_contextid", Namespace = "")]
		public int OriginalSystemContextid;

		[XmlElement(ElementName = "details", Namespace = "")]
		public Details Details;

		[XmlElement(ElementName = "contents", Namespace = "")]
		public Contents Contents;

		[XmlElement(ElementName = "settings", Namespace = "")]
		public Settings Settings;
	}
}

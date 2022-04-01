using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.moodle_backup
{
	[XmlRoot(ElementName = "information")]
	public class Information
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "moodle_version")]
		public string Moodle_version { get; set; }
		[XmlElement(ElementName = "moodle_release")]
		public string Moodle_release { get; set; }
		[XmlElement(ElementName = "backup_version")]
		public string Backup_version { get; set; }
		[XmlElement(ElementName = "backup_release")]
		public string Backup_release { get; set; }
		[XmlElement(ElementName = "backup_date")]
		public string Backup_date { get; set; }
		[XmlElement(ElementName = "mnet_remoteusers")]
		public string Mnet_remoteusers { get; set; }
		[XmlElement(ElementName = "include_files")]
		public string Include_files { get; set; }
		[XmlElement(ElementName = "include_file_references_to_external_content")]
		public string Include_file_references_to_external_content { get; set; }
		[XmlElement(ElementName = "original_wwwroot")]
		public string Original_wwwroot { get; set; }
		[XmlElement(ElementName = "original_site_identifier_hash")]
		public string Original_site_identifier_hash { get; set; }
		[XmlElement(ElementName = "original_course_id")]
		public string Original_course_id { get; set; }
		[XmlElement(ElementName = "original_course_format")]
		public string Original_course_format { get; set; }
		[XmlElement(ElementName = "original_course_fullname")]
		public string Original_course_fullname { get; set; }
		[XmlElement(ElementName = "original_course_shortname")]
		public string Original_course_shortname { get; set; }
		[XmlElement(ElementName = "original_course_startdate")]
		public string Original_course_startdate { get; set; }
		[XmlElement(ElementName = "original_course_enddate")]
		public string Original_course_enddate { get; set; }
		[XmlElement(ElementName = "original_course_contextid")]
		public string Original_course_contextid { get; set; }
		[XmlElement(ElementName = "original_system_contextid")]
		public string Original_system_contextid { get; set; }
		[XmlElement(ElementName = "details")]
		public Details Details { get; set; }
		[XmlElement(ElementName = "contents")]
		public Contents Contents { get; set; }
		[XmlElement(ElementName = "settings")]
		public Settings Settings { get; set; }
	}
}

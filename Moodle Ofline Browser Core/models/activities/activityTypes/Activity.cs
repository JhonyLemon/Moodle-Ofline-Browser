using Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign;
using Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes
{
	[XmlRoot(ElementName = "activity")]
	public class Activity
	{
        [XmlElement(ElementName = "attendance", Type = typeof(Attendance))]
        [XmlElement(ElementName = "assign", Type = typeof(Assign))]
		[XmlElement(ElementName = "bigbluebuttonbn", Type = typeof(bigbluebuttonbn.Bigbluebuttonbn))]
		[XmlElement(ElementName = "book", Type = typeof(book.Book))]
		[XmlElement(ElementName = "chat", Type = typeof(chat.Chat))]
		[XmlElement(ElementName = "checklist", Type = typeof(checklist.Checklist))]
		[XmlElement(ElementName = "choice", Type = typeof(choice.Choice))]
		[XmlElement(ElementName = "customcert", Type = typeof(customcert.Customcert))]
		[XmlElement(ElementName = "folder", Type = typeof(folder.Folder))]
		[XmlElement(ElementName = "forum", Type = typeof(forum.Forum))]
		[XmlElement(ElementName = "page", Type = typeof(page.Page))]
		[XmlElement(ElementName = "quiz", Type = typeof(quiz.Quiz))]
		[XmlElement(ElementName = "survey", Type = typeof(survey.Survey))]
		[XmlElement(ElementName = "url", Type = typeof(url.Url))]
		[XmlElement(ElementName = "wiki", Type = typeof(wiki.Wiki))]
		public ActivityType ActivityType { get; set; }

        [XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "moduleid")]
		public string Moduleid { get; set; }
		[XmlAttribute(AttributeName = "modulename")]
		public string Modulename { get; set; }
		[XmlAttribute(AttributeName = "contextid")]
		public string Contextid { get; set; }
	}
}

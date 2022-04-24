using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.forum
{
	[XmlRoot(ElementName = "post")]
	public class Post
	{
		[XmlElement(ElementName = "parent")]
		public string Parent { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "created")]
		public string Created { get; set; }
		[XmlElement(ElementName = "modified")]
		public string Modified { get; set; }
		[XmlElement(ElementName = "mailed")]
		public string Mailed { get; set; }
		[XmlElement(ElementName = "subject")]
		public string Subject { get; set; }
		[XmlElement(ElementName = "message")]
		public string Message { get; set; }
		[XmlElement(ElementName = "messageformat")]
		public string Messageformat { get; set; }
		[XmlElement(ElementName = "messagetrust")]
		public string Messagetrust { get; set; }
		[XmlElement(ElementName = "attachment")]
		public string Attachment { get; set; }
		[XmlElement(ElementName = "totalscore")]
		public string Totalscore { get; set; }
		[XmlElement(ElementName = "mailnow")]
		public string Mailnow { get; set; }
		[XmlElement(ElementName = "privatereplyto")]
		public string Privatereplyto { get; set; }
		[XmlElement(ElementName = "ratings")]
		public string Ratings { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "posts")]
	public class Posts
	{
		[XmlElement(ElementName = "post")]
		public List<Post> Post { get; set; }
	}

	[XmlRoot(ElementName = "discussion_sub")]
	public class Discussion_sub
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "preference")]
		public string Preference { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "discussion_subs")]
	public class Discussion_subs
	{
		[XmlElement(ElementName = "discussion_sub")]
		public List<Discussion_sub> Discussion_sub { get; set; }
	}

	[XmlRoot(ElementName = "discussion")]
	public class Discussion
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "firstpost")]
		public string Firstpost { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "groupid")]
		public string Groupid { get; set; }
		[XmlElement(ElementName = "assessed")]
		public string Assessed { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "usermodified")]
		public string Usermodified { get; set; }
		[XmlElement(ElementName = "timestart")]
		public string Timestart { get; set; }
		[XmlElement(ElementName = "timeend")]
		public string Timeend { get; set; }
		[XmlElement(ElementName = "pinned")]
		public string Pinned { get; set; }
		[XmlElement(ElementName = "timelocked")]
		public string Timelocked { get; set; }
		[XmlElement(ElementName = "posts")]
		public Posts Posts { get; set; }
		[XmlElement(ElementName = "discussion_subs")]
		public Discussion_subs Discussion_subs { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "discussions")]
	public class Discussions
	{
		[XmlElement(ElementName = "discussion")]
		public Discussion Discussion { get; set; }
	}

	[XmlRoot(ElementName = "read")]
	public class Read
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "discussionid")]
		public string Discussionid { get; set; }
		[XmlElement(ElementName = "postid")]
		public string Postid { get; set; }
		[XmlElement(ElementName = "firstread")]
		public string Firstread { get; set; }
		[XmlElement(ElementName = "lastread")]
		public string Lastread { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "readposts")]
	public class Readposts
	{
		[XmlElement(ElementName = "read")]
		public List<Read> Read { get; set; }
	}

	[XmlRoot(ElementName = "forum")]
	public class Forum : ActivityType
	{
		[XmlElement(ElementName = "type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "duedate")]
		public string Duedate { get; set; }
		[XmlElement(ElementName = "cutoffdate")]
		public string Cutoffdate { get; set; }
		[XmlElement(ElementName = "assessed")]
		public string Assessed { get; set; }
		[XmlElement(ElementName = "assesstimestart")]
		public string Assesstimestart { get; set; }
		[XmlElement(ElementName = "assesstimefinish")]
		public string Assesstimefinish { get; set; }
		[XmlElement(ElementName = "scale")]
		public string Scale { get; set; }
		[XmlElement(ElementName = "maxbytes")]
		public string Maxbytes { get; set; }
		[XmlElement(ElementName = "maxattachments")]
		public string Maxattachments { get; set; }
		[XmlElement(ElementName = "forcesubscribe")]
		public string Forcesubscribe { get; set; }
		[XmlElement(ElementName = "trackingtype")]
		public string Trackingtype { get; set; }
		[XmlElement(ElementName = "rsstype")]
		public string Rsstype { get; set; }
		[XmlElement(ElementName = "rssarticles")]
		public string Rssarticles { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "warnafter")]
		public string Warnafter { get; set; }
		[XmlElement(ElementName = "blockafter")]
		public string Blockafter { get; set; }
		[XmlElement(ElementName = "blockperiod")]
		public string Blockperiod { get; set; }
		[XmlElement(ElementName = "completiondiscussions")]
		public string Completiondiscussions { get; set; }
		[XmlElement(ElementName = "completionreplies")]
		public string Completionreplies { get; set; }
		[XmlElement(ElementName = "completionposts")]
		public string Completionposts { get; set; }
		[XmlElement(ElementName = "displaywordcount")]
		public string Displaywordcount { get; set; }
		[XmlElement(ElementName = "lockdiscussionafter")]
		public string Lockdiscussionafter { get; set; }
		[XmlElement(ElementName = "grade_forum")]
		public string Grade_forum { get; set; }
		[XmlElement(ElementName = "discussions")]
		public Discussions Discussions { get; set; }
		[XmlElement(ElementName = "subscriptions")]
		public string Subscriptions { get; set; }
		[XmlElement(ElementName = "digests")]
		public string Digests { get; set; }
		[XmlElement(ElementName = "readposts")]
		public Readposts Readposts { get; set; }
		[XmlElement(ElementName = "trackedprefs")]
		public string Trackedprefs { get; set; }
		[XmlElement(ElementName = "poststags")]
		public string Poststags { get; set; }
		[XmlElement(ElementName = "grades")]
		public string Grades { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

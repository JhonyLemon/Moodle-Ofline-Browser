using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.activities.activityTypes.quiz
{
	[XmlRoot(ElementName = "question_instance")]
	public class Question_instance
	{
		[XmlElement(ElementName = "slot")]
		public string Slot { get; set; }
		[XmlElement(ElementName = "page")]
		public string Page { get; set; }
		[XmlElement(ElementName = "requireprevious")]
		public string Requireprevious { get; set; }
		[XmlElement(ElementName = "questionid")]
		public string Questionid { get; set; }
		[XmlElement(ElementName = "questioncategoryid")]
		public string Questioncategoryid { get; set; }
		[XmlElement(ElementName = "includingsubcategories")]
		public string Includingsubcategories { get; set; }
		[XmlElement(ElementName = "maxmark")]
		public string Maxmark { get; set; }
		[XmlElement(ElementName = "tags")]
		public string Tags { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "question_instances")]
	public class Question_instances
	{
		[XmlElement(ElementName = "question_instance")]
		public Question_instance Question_instance { get; set; }
	}

	[XmlRoot(ElementName = "section")]
	public class Section
	{
		[XmlElement(ElementName = "firstslot")]
		public string Firstslot { get; set; }
		[XmlElement(ElementName = "heading")]
		public string Heading { get; set; }
		[XmlElement(ElementName = "shufflequestions")]
		public string Shufflequestions { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "sections")]
	public class Sections
	{
		[XmlElement(ElementName = "section")]
		public Section Section { get; set; }
	}

	[XmlRoot(ElementName = "feedback")]
	public class Feedback
	{
		[XmlElement(ElementName = "feedbacktext")]
		public string Feedbacktext { get; set; }
		[XmlElement(ElementName = "feedbacktextformat")]
		public string Feedbacktextformat { get; set; }
		[XmlElement(ElementName = "mingrade")]
		public string Mingrade { get; set; }
		[XmlElement(ElementName = "maxgrade")]
		public string Maxgrade { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "feedbacks")]
	public class Feedbacks
	{
		[XmlElement(ElementName = "feedback")]
		public List<Feedback> Feedback { get; set; }
	}

	[XmlRoot(ElementName = "grade", Namespace = "quiz")]
	public class Grade
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "gradeval")]
		public string Gradeval { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "grades", Namespace = "quiz")]
	public class Grades
	{
		[XmlElement(ElementName = "grade", Namespace = "quiz")]
		public List<Grade> Grade { get; set; }
	}

	[XmlRoot(ElementName = "step")]
	public class Step
	{
		[XmlElement(ElementName = "sequencenumber")]
		public string Sequencenumber { get; set; }
		[XmlElement(ElementName = "state")]
		public string State { get; set; }
		[XmlElement(ElementName = "fraction")]
		public string Fraction { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "response")]
		public Response Response { get; set; }
	}

	[XmlRoot(ElementName = "variable")]
	public class Variable
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "response")]
	public class Response
	{
		[XmlElement(ElementName = "variable")]
		public Variable Variable { get; set; }
	}

	[XmlRoot(ElementName = "steps")]
	public class Steps
	{
		[XmlElement(ElementName = "step")]
		public List<Step> Step { get; set; }
	}

	[XmlRoot(ElementName = "question_attempt")]
	public class Question_attempt
	{
		[XmlElement(ElementName = "slot")]
		public string Slot { get; set; }
		[XmlElement(ElementName = "behaviour")]
		public string Behaviour { get; set; }
		[XmlElement(ElementName = "questionid")]
		public string Questionid { get; set; }
		[XmlElement(ElementName = "variant")]
		public string Variant { get; set; }
		[XmlElement(ElementName = "maxmark")]
		public string Maxmark { get; set; }
		[XmlElement(ElementName = "minfraction")]
		public string Minfraction { get; set; }
		[XmlElement(ElementName = "maxfraction")]
		public string Maxfraction { get; set; }
		[XmlElement(ElementName = "flagged")]
		public string Flagged { get; set; }
		[XmlElement(ElementName = "questionsummary")]
		public string Questionsummary { get; set; }
		[XmlElement(ElementName = "rightanswer")]
		public string Rightanswer { get; set; }
		[XmlElement(ElementName = "responsesummary")]
		public string Responsesummary { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "steps")]
		public Steps Steps { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "question_attempts")]
	public class Question_attempts
	{
		[XmlElement(ElementName = "question_attempt")]
		public Question_attempt Question_attempt { get; set; }
	}

	[XmlRoot(ElementName = "question_usage")]
	public class Question_usage
	{
		[XmlElement(ElementName = "component")]
		public string Component { get; set; }
		[XmlElement(ElementName = "preferredbehaviour")]
		public string Preferredbehaviour { get; set; }
		[XmlElement(ElementName = "question_attempts")]
		public Question_attempts Question_attempts { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "attempt")]
	public class Attempt
	{
		[XmlElement(ElementName = "userid")]
		public string Userid { get; set; }
		[XmlElement(ElementName = "attemptnum")]
		public string Attemptnum { get; set; }
		[XmlElement(ElementName = "uniqueid")]
		public string Uniqueid { get; set; }
		[XmlElement(ElementName = "layout")]
		public string Layout { get; set; }
		[XmlElement(ElementName = "currentpage")]
		public string Currentpage { get; set; }
		[XmlElement(ElementName = "preview")]
		public string Preview { get; set; }
		[XmlElement(ElementName = "state")]
		public string State { get; set; }
		[XmlElement(ElementName = "timestart")]
		public string Timestart { get; set; }
		[XmlElement(ElementName = "timefinish")]
		public string Timefinish { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "timemodifiedoffline")]
		public string Timemodifiedoffline { get; set; }
		[XmlElement(ElementName = "timecheckstate")]
		public string Timecheckstate { get; set; }
		[XmlElement(ElementName = "sumgrades")]
		public string Sumgrades { get; set; }
		[XmlElement(ElementName = "question_usage")]
		public Question_usage Question_usage { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "attempts")]
	public class Attempts
	{
		[XmlElement(ElementName = "attempt")]
		public List<Attempt> Attempt { get; set; }
	}

	[XmlRoot(ElementName = "quiz")]
	public class Quiz : ActivityType
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "intro")]
		public string Intro { get; set; }
		[XmlElement(ElementName = "introformat")]
		public string Introformat { get; set; }
		[XmlElement(ElementName = "timeopen")]
		public string Timeopen { get; set; }
		[XmlElement(ElementName = "timeclose")]
		public string Timeclose { get; set; }
		[XmlElement(ElementName = "timelimit")]
		public string Timelimit { get; set; }
		[XmlElement(ElementName = "overduehandling")]
		public string Overduehandling { get; set; }
		[XmlElement(ElementName = "graceperiod")]
		public string Graceperiod { get; set; }
		[XmlElement(ElementName = "preferredbehaviour")]
		public string Preferredbehaviour { get; set; }
		[XmlElement(ElementName = "canredoquestions")]
		public string Canredoquestions { get; set; }
		[XmlElement(ElementName = "attempts_number")]
		public string Attempts_number { get; set; }
		[XmlElement(ElementName = "attemptonlast")]
		public string Attemptonlast { get; set; }
		[XmlElement(ElementName = "grademethod")]
		public string Grademethod { get; set; }
		[XmlElement(ElementName = "decimalpoints")]
		public string Decimalpoints { get; set; }
		[XmlElement(ElementName = "questiondecimalpoints")]
		public string Questiondecimalpoints { get; set; }
		[XmlElement(ElementName = "reviewattempt")]
		public string Reviewattempt { get; set; }
		[XmlElement(ElementName = "reviewcorrectness")]
		public string Reviewcorrectness { get; set; }
		[XmlElement(ElementName = "reviewmarks")]
		public string Reviewmarks { get; set; }
		[XmlElement(ElementName = "reviewspecificfeedback")]
		public string Reviewspecificfeedback { get; set; }
		[XmlElement(ElementName = "reviewgeneralfeedback")]
		public string Reviewgeneralfeedback { get; set; }
		[XmlElement(ElementName = "reviewrightanswer")]
		public string Reviewrightanswer { get; set; }
		[XmlElement(ElementName = "reviewoverallfeedback")]
		public string Reviewoverallfeedback { get; set; }
		[XmlElement(ElementName = "questionsperpage")]
		public string Questionsperpage { get; set; }
		[XmlElement(ElementName = "navmethod")]
		public string Navmethod { get; set; }
		[XmlElement(ElementName = "shuffleanswers")]
		public string Shuffleanswers { get; set; }
		[XmlElement(ElementName = "sumgrades")]
		public string Sumgrades { get; set; }
		[XmlElement(ElementName = "grade")]
		public string Grade { get; set; }
		[XmlElement(ElementName = "timecreated")]
		public string Timecreated { get; set; }
		[XmlElement(ElementName = "timemodified")]
		public string Timemodified { get; set; }
		[XmlElement(ElementName = "password")]
		public string Password { get; set; }
		[XmlElement(ElementName = "subnet")]
		public string Subnet { get; set; }
		[XmlElement(ElementName = "browsersecurity")]
		public string Browsersecurity { get; set; }
		[XmlElement(ElementName = "delay1")]
		public string Delay1 { get; set; }
		[XmlElement(ElementName = "delay2")]
		public string Delay2 { get; set; }
		[XmlElement(ElementName = "showuserpicture")]
		public string Showuserpicture { get; set; }
		[XmlElement(ElementName = "showblocks")]
		public string Showblocks { get; set; }
		[XmlElement(ElementName = "completionattemptsexhausted")]
		public string Completionattemptsexhausted { get; set; }
		[XmlElement(ElementName = "completionpass")]
		public string Completionpass { get; set; }
		[XmlElement(ElementName = "completionminattempts")]
		public string Completionminattempts { get; set; }
		[XmlElement(ElementName = "allowofflineattempts")]
		public string Allowofflineattempts { get; set; }
		[XmlElement(ElementName = "subplugin_quizaccess_seb_quiz")]
		public string Subplugin_quizaccess_seb_quiz { get; set; }
		[XmlElement(ElementName = "question_instances")]
		public Question_instances Question_instances { get; set; }
		[XmlElement(ElementName = "sections")]
		public Sections Sections { get; set; }
		[XmlElement(ElementName = "feedbacks")]
		public Feedbacks Feedbacks { get; set; }
		[XmlElement(ElementName = "overrides")]
		public string Overrides { get; set; }
		[XmlElement(ElementName = "grades", Namespace = "quiz")]
		public Grades Grades { get; set; }
		[XmlElement(ElementName = "attempts")]
		public Attempts Attempts { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.inforef.type.course
{
	[XmlRoot(ElementName = "inforef")]
	public class Course : inforef.Inforef
    {
		[XmlElement(ElementName = "groupref")]
		public Groupref Groupref { get; set; }

		[XmlElement(ElementName = "roleref")]
		public Roleref Roleref { get; set; }

		[XmlElement(ElementName = "question_categoryref")]
		public Question_categoryref Question_categoryref { get; set; }
	}
}

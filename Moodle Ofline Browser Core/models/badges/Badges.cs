﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.badges
{
		[XmlRoot(ElementName = "badges")]
		public class Badges
		{
			[XmlElement(ElementName = "badge")]
			public Badge Badge { get; set; }
		}
}

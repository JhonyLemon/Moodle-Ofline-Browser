﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Moodle_Ofline_Browser_Core.models.inforef
{
	public abstract class Inforef
		{
			[XmlElement(ElementName = "userref")]
			public Userref Userref { get; set; }
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_Core.models
{
    public class Progress
    {
        public string Message { get; set; }
        public int Percentage { get; set; }
        public string CallerTask { get; set; }

        public Progress(string message, int percentage, string callerTask)
        {
            Message = message;
            Percentage = percentage;
            CallerTask = callerTask;
        }

        public Progress()
        {
        }
    }
}

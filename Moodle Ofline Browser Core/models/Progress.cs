using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_Core.models
{
    public class Progress
    {
        public string Filename { get; set; }
        public string ErrorMessage { get; set; }
        public int Percentage { get; set; }
        public string CallerTask { get; set; }

        public Progress(string filename, string errorMessage, int percentage, string callerTask)
        {
            Filename = filename;
            ErrorMessage = errorMessage;
            Percentage = percentage;
            CallerTask = callerTask;
        }

        public Progress()
        {
        }
    }
}

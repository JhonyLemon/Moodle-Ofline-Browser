using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle_Ofline_Browser_Core.models;

namespace Moodle_Ofline_Browser_GUI.Models
{
    public class ReportDataProviderProgress
    {
        public int Percentage { get; set; }
        public ProgressReportEventArgs Progress { get; set; }
        public string Message { get; set; }
    }
}

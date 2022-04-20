using Moodle_Ofline_Browser_Core.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_Core
{
    public abstract class CoreModule
    {
        public event EventHandler<ProgressReportEventArgs> ProgressReport;

        protected virtual void OnProgressReport(ProgressReportEventArgs e)
        {
            EventHandler<ProgressReportEventArgs> handler = ProgressReport;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected void WriteLogToFile(string Name, string Message)
        {
            using (FileStream fileStream = new FileStream(Name, FileMode.Append))
            {
                try
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("[" + DateTime.Now.ToString("G") + "] " + Message + '\n');
                    fileStream.Write(info, 0, info.Length);
                }
                catch (Exception)
                {

                    OnProgressReport(new ProgressReportEventArgs("Nie można zapisać do pliku", 0, "fileLog"));
                }
            }
        }
        protected virtual ProgressReportEventArgs MakeResult(string shortName, bool isOk)
        {
            ProgressReportEventArgs result = null;
            result = new ProgressReportEventArgs();
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_Core;

namespace Moodle_Ofline_Browser_GUI.Helpers
{
    public class DataProviderHelper
    {
        public string PathFrom { get; set; }
        public string PathTo { get; set; }
        public List<Progress> Progresses { get; private set; }
        public int Completion { get; private set; }
        public int CompletionDecompression { get; private set; }
        public int CompletionParsing { get; private set; }
        private Progress<Progress> progress;
        public event EventHandler<Models.ReportProgressEventArgs> ReportProgress;


        public DataProviderHelper(string pathFrom, string pathTo)
        {
            PathFrom = pathFrom;
            PathTo = pathTo;
            Progresses = new List<Progress>();
            progress = new Progress<Progress>();
            progress.ProgressChanged += OnReportProgress;
            CompletionDecompression = 0;
            CompletionParsing = 0;
        }

        public DataProviderHelper(string pathTo)
        {
            PathTo = pathTo;
            PathTo = "";
            Progresses = new List<Progress>();
            progress = new Progress<Progress>();
            progress.ProgressChanged += OnReportProgress;
            CompletionDecompression = 100;
        }
        public DataProviderHelper()
        {
            PathFrom = "";
            PathTo = "";
            Progresses = new List<Progress>();
            progress = new Progress<Progress>();
            progress.ProgressChanged += OnReportProgress;
            CompletionDecompression = 0;
            CompletionParsing = 0;
        }

        public async Task<FullCourse> GetFullCourse()
        {
            FullCourse fullCourse = null;

            if (PathFrom == "")
            {
                CompletionDecompression = 100;
            }
            else
            {
               await MbzDecompressor.Extract(PathFrom, PathTo, progress);
            }
            fullCourse=await Moodle_Ofline_Browser_Core.MoodleBackupParser.Parse(PathTo,progress);
            return fullCourse;
        }
        private void OnReportProgress(object sender, Progress e)
        {
            Progresses.Add(e);
            UpdateCompletion(e);
            Models.ReportProgressEventArgs eventArgs = new Models.ReportProgressEventArgs();
            eventArgs.Percentage = Completion / 2;
            eventArgs.Progress = e;
            OnResportProgress(eventArgs);
        }

        private void UpdateCompletion(Progress e)
        {
            if(e.CallerTask=="Parser" && CompletionParsing!=100)
            {
                CompletionParsing = e.Percentage;
            }
            else if(e.CallerTask == "Decompressor" && CompletionDecompression != 100)
            {
                CompletionDecompression = e.Percentage;
            }
            Completion = CompletionDecompression + CompletionParsing;
        }

        protected virtual void OnResportProgress(Models.ReportProgressEventArgs e)
        {
            EventHandler<Models.ReportProgressEventArgs> handler = ReportProgress;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}

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
        public List<ProgressReportEventArgs> Progresses { get; private set; }
        public int Completion { get; private set; }
        public int CompletionDecompression { get; private set; }
        public int CompletionParsing { get; private set; }
        private IProgress<Models.ReportDataProviderProgress> progress;
        private MbzDecompressor mbzDecompressor;
        private MoodleBackupParser backupParser;


        public DataProviderHelper(string pathFrom, string pathTo, IProgress<Models.ReportDataProviderProgress> progress)
        {
            PathFrom = pathFrom;
            PathTo = pathTo;
            Progresses = new List<ProgressReportEventArgs>();
            CompletionDecompression = 0;
            CompletionParsing = 0;
            backupParser = new MoodleBackupParser();
            mbzDecompressor = new MbzDecompressor();
            backupParser.ProgressReport += ProgressReport;
            mbzDecompressor.ProgressReport += ProgressReport;
            this.progress = progress;
        }

        public DataProviderHelper(string pathTo, IProgress<Models.ReportDataProviderProgress> progress)
        {
            PathTo = pathTo;
            PathTo = "";
            Progresses = new List<ProgressReportEventArgs>();
            CompletionDecompression = 100;
            backupParser = new MoodleBackupParser();
            mbzDecompressor = new MbzDecompressor();
            backupParser.ProgressReport += ProgressReport;
            mbzDecompressor.ProgressReport += ProgressReport;
            this.progress = progress;
        }
        public DataProviderHelper(IProgress<Models.ReportDataProviderProgress> progress)
        {
            PathFrom = "";
            PathTo = "";
            Progresses = new List<ProgressReportEventArgs>();
            CompletionDecompression = 0;
            CompletionParsing = 0;
            backupParser = new MoodleBackupParser();
            mbzDecompressor = new MbzDecompressor();
            backupParser.ProgressReport += ProgressReport;
            mbzDecompressor.ProgressReport += ProgressReport;
            this.progress = progress;
        }

        private void ProgressReport(object sender, ProgressReportEventArgs e)
        {
            Progresses.Add(e);
            UpdateCompletion(e);
            Models.ReportDataProviderProgress result = new Models.ReportDataProviderProgress();
            result.Percentage = Completion;
            result.Progress = e;
            progress.Report(result);
        }

        public FullCourse GetFullCourse()
        {
            FullCourse fullCourse = null;

            if (PathFrom == "")
            {
                CompletionDecompression = 100;
            }
            else
            {
               mbzDecompressor.Extract(PathFrom, PathTo);
            }
            fullCourse=backupParser.Parse(PathTo);
            return fullCourse;
        }
        private void UpdateCompletion(ProgressReportEventArgs e)
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
    }
}

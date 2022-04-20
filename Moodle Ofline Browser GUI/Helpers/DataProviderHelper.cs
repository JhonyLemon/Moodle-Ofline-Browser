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
        private string File;
        private string Folder;

        private static readonly string LogFileName = "MoodleOflineBrowser.log";
        public List<ProgressReportEventArgs> Progresses { get; private set; }
        public int Completion { get; private set; }
        public int CompletionDecompression { get; private set; }
        public int CompletionParsing { get; private set; }
        public bool GenerateLogFile { get; set; }
        private IProgress<Models.ReportDataProviderProgress> progress;
        private MbzDecompressor mbzDecompressor;
        private MoodleBackupParser backupParser;


        public DataProviderHelper(string file, string folder, IProgress<Models.ReportDataProviderProgress> progress)
        {
            File = file;
            Folder = folder;
            Progresses = new List<ProgressReportEventArgs>();
            CompletionDecompression = 0;
            CompletionParsing = 0;
            backupParser = new MoodleBackupParser();
            mbzDecompressor = new MbzDecompressor();
            GenerateLogFile = true;
            backupParser.ProgressReport += ProgressReport;
            mbzDecompressor.ProgressReport += ProgressReport;
            this.progress = progress;
        }

        public DataProviderHelper(string folder, IProgress<Models.ReportDataProviderProgress> progress)
        {
            File = "";
            Folder = folder;
            Progresses = new List<ProgressReportEventArgs>();
            CompletionDecompression = 100;
            backupParser = new MoodleBackupParser();
            GenerateLogFile = false;
            mbzDecompressor = new MbzDecompressor();
            backupParser.ProgressReport += ProgressReport;
            mbzDecompressor.ProgressReport += ProgressReport;
            this.progress = progress;
        }
        public DataProviderHelper(IProgress<Models.ReportDataProviderProgress> progress)
        {
            File = "";
            Folder = "";
            Progresses = new List<ProgressReportEventArgs>();
            CompletionDecompression = 0;
            CompletionParsing = 0;
            GenerateLogFile = true;
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
            result.Message = e.Message;
            result.Progress = e;
            progress.Report(result);
        }

        public async Task<FullCourse> GetFullCourse()
        {
            FullCourse fullCourse = null;
            if (File == "")
            {
                CompletionDecompression = 100;
            }
            else
            {
                if(GenerateLogFile)
                    await Task.Run(() => mbzDecompressor.Extract(File, Folder,LogFileName));
                else
                    await Task.Run(() => mbzDecompressor.Extract(File, Folder, null));
            };
            if (GenerateLogFile)
                await Task.Run(() => fullCourse = backupParser.Parse(Folder, LogFileName));
            else
                await Task.Run(() => fullCourse = backupParser.Parse(Folder, null));
            return fullCourse;
        }
        private void UpdateCompletion(ProgressReportEventArgs e)
        {
            if(e.CallerTask==MoodleBackupParser.CALLER_NAME && CompletionParsing!=100)
            {
                CompletionParsing = e.Percentage;
            }
            else if(e.CallerTask == MbzDecompressor.CALLER_NAME && CompletionDecompression != 100)
            {
                CompletionDecompression = e.Percentage;
            }
            Completion = CompletionDecompression + CompletionParsing;
        }
    }
}

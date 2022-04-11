using Caliburn.Micro;
using Microsoft.Win32;
using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_GUI.Helpers;
using Moodle_Ofline_Browser_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Moodle_Ofline_Browser_GUI.EventModels;
using System.IO;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class EnterBackupFileViewModel : Caliburn.Micro.Screen
    {
        private IEventAggregator _eventAggregator;
        private string _filePath = "";
        private string _folderPath = "";
        private int progressBar;
        private Progress<Models.ReportDataProviderProgress> progress;
        private Helpers.DataProviderHelper providerHelper;
        private FullCourse fullCourse;
        public string FilePath
        {
            get { return _filePath; }
            set 
            { 
                _filePath = value;
                NotifyOfPropertyChange(() => FilePath);
            }
        }

        public string FolderPath
        {
            get { return _folderPath; }
            set 
            { 
                _folderPath = value;
                NotifyOfPropertyChange(() => FolderPath);
            }
        }

        public int ProgressBar
        {
            get { return progressBar; }
            set
            {
                if (progressBar == value)
                {
                    return;
                }

                progressBar = value;
                NotifyOfPropertyChange(() => progressBar);
            }
        }

        public EnterBackupFileViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            progress = new Progress<Models.ReportDataProviderProgress>();
            providerHelper = new DataProviderHelper(progress);
            progress.ProgressChanged += ProviderHelper_ReportProgress;
        }

        private void ProviderHelper_ReportProgress(object sender, ReportDataProviderProgress e)
        {
            Console.WriteLine(e.Percentage + "% " + e.Progress.Message);
            ProgressBar = e.Percentage;
            if(ProgressBar == 200)
            {
                _eventAggregator.PublishOnUIThread(new MainOnEvent(1));
            }
        }

        public void ChooseFile()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();

            if(dialog.ShowDialog() == true)
            {
                FilePath = dialog.FileName;
            }
        }

        public void ChooseFolder()
        {
            var dialog = new FolderBrowserDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = dialog.SelectedPath;
            }
        }

        public async void Extract()
        {
            string ext;
            ext = Path.GetExtension(FilePath);
            if (FilePath.Length == 0 || FolderPath.Length == 0)
            {
                MessageBox.Show("Wybierz obie sciezki", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(ext != ".mbz")
            {
                MessageBox.Show("Nieprawidłowy plik", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!System.IO.Directory.Exists(FolderPath))
            {
                MessageBox.Show("Nieprawidłowa ścieżki do pliku", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                providerHelper.PathFrom = FilePath;
                providerHelper.PathTo = FolderPath;
                fullCourse = await GetDataAsync(providerHelper);
            }
        }

        private static async Task<FullCourse> GetDataAsync(DataProviderHelper helper)
        {
            FullCourse fullCourse=null;
            fullCourse= await helper.GetFullCourse();
            return fullCourse;
        }
    }
}

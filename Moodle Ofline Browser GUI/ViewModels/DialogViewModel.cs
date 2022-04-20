using Caliburn.Micro;
using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.Helpers;
using Moodle_Ofline_Browser_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class DialogViewModel: Caliburn.Micro.Screen
    {
        private IEventAggregator _eventAggregator;
        private ObservableCollection<ReportDataProviderProgress> logs;
        private Progress<ReportDataProviderProgress> progress;
        private Helpers.DataProviderHelper providerHelper;
        public FullCourse FullCourse { get; set; }

        private bool backupRadio = false;
        private bool folderRadio = false;
        private bool logCheckBox;
        public bool IsNewData { get; set; } = false;

        private Visibility logsVisibility;
        private Visibility goBackVisibility;
        private Visibility backupVisibility;
        private Visibility folderVisibility;
        private Visibility progresVisibility;
        private Visibility startLoadingVisibility;
        private Visibility backupRadioVisibility;
        private Visibility folderRadioVisibility;
        private Visibility logCheckBoxVisibility;

        private string selectCompressedFilePath;
        private string selectDecompresionOutputFolderPath;
        private string selectCourseFolderPath;

        private int progressBar;

        public DialogViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            BackupRadio = false;
            FolderRadio = false;
            LogCheckBox = true;
            SelectCompressedFilePath = "";
            SelectDecompresionOutputFolderPath = "";
            SelectCourseFolderPath = "";

            BackupVisibility = Visibility.Collapsed;
            LogCheckBoxVisibility = Visibility.Collapsed;
            FolderVisibility = Visibility.Collapsed;
            ProgresVisibility = Visibility.Collapsed;
            StartLoadingVisibility = Visibility.Collapsed;
            LogsVisibility = Visibility.Collapsed;

            progress = new Progress<ReportDataProviderProgress>();
            progress.ProgressChanged += ProviderHelper_ReportProgress;

            Logs = new ObservableCollection<ReportDataProviderProgress>();
        }

        #region Get&Set

        public ObservableCollection<ReportDataProviderProgress> Logs
        {
            get { return logs; }
            set
            {
                logs = value;
                NotifyOfPropertyChange(() => Logs);
            }
        }

       

         public bool BackupRadio
        {
            get { return backupRadio; }
            set
            {
                if (value)
                {
                    BackupVisibility = Visibility.Visible;
                }
                else if (!value)
                {
                    BackupVisibility = Visibility.Collapsed;
                }
                backupRadio = value;
                NotifyOfPropertyChange(() => BackupRadio);

       

            }
        }
        public bool LogCheckBox
        {
            get { return logCheckBox; }
            set
            {
                logCheckBox = value;
                NotifyOfPropertyChange(() => LogCheckBox);
            }
        }
        public bool FolderRadio
        {
            get { return folderRadio; }
            set
            {
                if (value)
                {
                    FolderVisibility = Visibility.Visible;
                }
                else if (!value)
                {
                    FolderVisibility = Visibility.Collapsed;
                }
                folderRadio = value;
                NotifyOfPropertyChange(() => folderRadio);
            }
        }

        public Visibility LogCheckBoxVisibility
        {
            get { return logCheckBoxVisibility; }
            set
            {
                logCheckBoxVisibility = value;
                NotifyOfPropertyChange(() => LogCheckBoxVisibility);
            }
        }
        public Visibility LogsVisibility
        {
            get { return logsVisibility; }
            set
            {
                logsVisibility = value;
                NotifyOfPropertyChange(() => LogsVisibility);
            }
        }
        public Visibility GoBackVisibility
        {
            get { return goBackVisibility; }
            set
            {
                goBackVisibility = value;
                NotifyOfPropertyChange(() => GoBackVisibility);
            }
        }
        public Visibility BackupVisibility
        {
            get { return backupVisibility; }
            set
            {
                backupVisibility = value;
                NotifyOfPropertyChange(() => BackupVisibility);
            }
        }
        public Visibility FolderVisibility
        {
            get { return folderVisibility; }
            set
            {
                folderVisibility = value;
                NotifyOfPropertyChange(() => FolderVisibility);
            }
        }
        public Visibility BackupRadioVisibility
        {
            get { return backupRadioVisibility; }
            set
            {
                backupRadioVisibility = value;
                NotifyOfPropertyChange(() => BackupRadioVisibility);
            }
        }
        public Visibility FolderRadioVisibility
        {
            get { return folderRadioVisibility; }
            set
            {
                folderRadioVisibility = value;
                NotifyOfPropertyChange(() => FolderRadioVisibility);
            }
        }
        public Visibility ProgresVisibility
        {
            get { return progresVisibility; }
            set
            {
                progresVisibility = value;
                NotifyOfPropertyChange(() => ProgresVisibility);
            }
        }
        public Visibility StartLoadingVisibility
        {
            get { return startLoadingVisibility; }
            set
            {
                startLoadingVisibility = value;
                NotifyOfPropertyChange(() => StartLoadingVisibility);
            }
        }
        public string SelectCompressedFilePath
        {
            get { return selectCompressedFilePath; }
            set
            {
                selectCompressedFilePath = value;
                NotifyOfPropertyChange(() => SelectCompressedFilePath);
                CheckIfPathValid();
            }
        }
        public string SelectDecompresionOutputFolderPath
        {
            get { return selectDecompresionOutputFolderPath; }
            set
            {
                selectDecompresionOutputFolderPath = value;
                NotifyOfPropertyChange(() => SelectDecompresionOutputFolderPath);
                CheckIfPathValid();
            }
        }
        public string SelectCourseFolderPath
        {
            get { return selectCourseFolderPath; }
            set
            {
                selectCourseFolderPath = value;
                NotifyOfPropertyChange(() => SelectCourseFolderPath);
                CheckIfPathValid();
            }
        }
        public int ProgressBar
        {
            get { return progressBar; }
            set
            {
                progressBar = value;
                NotifyOfPropertyChange(() => ProgressBar);
            }
        }

        #endregion

        #region Button Handlers


        public void SelectCompressedFile()
        {
            _eventAggregator.PublishOnUIThread(new CanClickAway(false));
            var dialog = new Microsoft.Win32.OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                SelectCompressedFilePath = dialog.FileName;
                CheckIfPathValid();
            }
            Task.Delay(1000).ContinueWith(t => _eventAggregator.PublishOnUIThread(new CanClickAway(true)));
        }

        public void SelectDecompresionOutputFolder()
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectDecompresionOutputFolderPath = dialog.SelectedPath;
                CheckIfPathValid();
            }
        }

        public void SelectCourseFolder()
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectCourseFolderPath = dialog.SelectedPath;
                CheckIfPathValid();
            }
        }

        public bool CanStartLoading(bool val)
        {
            return val;
        }

        public async void StartLoading()
        {
            if (BackupRadio)
            {
                providerHelper = new DataProviderHelper(SelectCompressedFilePath, SelectDecompresionOutputFolderPath, progress);
            }
            else if (FolderRadio)
            {
                providerHelper = new DataProviderHelper(SelectCourseFolderPath, progress);
            }
            providerHelper.GenerateLogFile = LogCheckBox;
            BackupRadioVisibility = Visibility.Collapsed;
            LogsVisibility = Visibility.Visible;
            LogCheckBoxVisibility = Visibility.Collapsed;
            ProgresVisibility = Visibility.Visible;
            BackupVisibility = Visibility.Collapsed;
            FolderRadioVisibility = Visibility.Collapsed;
            FolderVisibility = Visibility.Collapsed;
            StartLoadingVisibility = Visibility.Collapsed;
            _eventAggregator.PublishOnUIThread(new CanClickAway(false));
            FullCourse = await Task.Run(() => providerHelper.GetFullCourse());
            _eventAggregator.PublishOnUIThread(new CanClickAway(true));
            IsNewData = true;
        }

        #endregion

        public bool CheckIfPathValid()
        {
            bool isValid = false;
            if (BackupRadio)
            {
                isValid = PathChecker.CheckCompressedFilePath(SelectCompressedFilePath) && PathChecker.CheckOutputFolder(SelectDecompresionOutputFolderPath);
            }
            else if (FolderRadio)
            {
                isValid = PathChecker.CheckCourseFolder(SelectCourseFolderPath);
            }
            if (isValid)
            {
                StartLoadingVisibility = Visibility.Visible;
                LogCheckBoxVisibility = Visibility.Visible;
            }
            else
            {
                StartLoadingVisibility = Visibility.Collapsed;
                LogCheckBoxVisibility = Visibility.Collapsed;
            }
            CanStartLoading(isValid);
            return isValid;
        }

        private void ProviderHelper_ReportProgress(object sender, ReportDataProviderProgress e)
        {
            // Console.WriteLine(e.Percentage + "% " + e.Progress.Message);
            ProgressBar = e.Percentage;
            Logs.Add(e);
            NotifyOfPropertyChange(() => Logs);
        }

        public void ClearDialogBox()
        {
            BackupRadioVisibility = Visibility.Visible;
            FolderRadioVisibility = Visibility.Visible;

            BackupRadio = false;
            FolderRadio = false;
            logCheckBox = true;

            BackupVisibility = Visibility.Collapsed;
            FolderVisibility = Visibility.Collapsed;
            ProgresVisibility = Visibility.Collapsed;
            StartLoadingVisibility = Visibility.Collapsed;
            LogsVisibility = Visibility.Collapsed;
            LogCheckBoxVisibility = Visibility.Collapsed;
            Logs.Clear();
            IsNewData = false;
            ProgressBar = 0;

            SelectCompressedFilePath = "";
            SelectDecompresionOutputFolderPath = "";
            SelectCourseFolderPath = "";
        }
    }
}

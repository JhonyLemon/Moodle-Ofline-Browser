using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.ViewModels;
using System.Windows;
using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_GUI.Helpers;
using Moodle_Ofline_Browser_GUI.Models;
using System.Windows.Forms;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class ShellViewModel : Conductor<object>, IHandle<MainOnEvent>
    {
        private IEventAggregator _eventAggregator;
        private MainViewModel _mainViewModel;
        private Caliburn.Micro.Screen previouslyActive;

        
        private bool dialogIsOpen;
        private int menuIndex;

        private Progress<Models.ReportDataProviderProgress> progress;
        private Helpers.DataProviderHelper providerHelper;
        private FullCourse fullCourse;



        private bool backupRadio = false;
        private bool folderRadio = false;

        private Visibility goBackVisibility;
        private Visibility backupVisibility;
        private Visibility folderVisibility;
        private Visibility progresVisibility;
        private Visibility startLoadingVisibility;

        private string selectCompressedFilePath;
        private string selectDecompresionOutputFolderPath;
        private string selectCourseFolderPath;

        private int progressBar;

        public ShellViewModel(IEventAggregator eventAggregator, MainViewModel mainViewModel)
        {
            _eventAggregator = eventAggregator;
            _mainViewModel = mainViewModel;
            _eventAggregator.Subscribe(this);
            ActivateItem(_mainViewModel);

            MenuIndex = 1;
            GoBackVisibility = Visibility.Hidden;

            BackupRadio = false;
            FolderRadio = false;

            BackupVisibility = Visibility.Collapsed;
            FolderVisibility = Visibility.Collapsed;
            ProgresVisibility = Visibility.Collapsed;
            StartLoadingVisibility = Visibility.Collapsed;

            progress = new Progress<ReportDataProviderProgress>();
            progress.ProgressChanged += ProviderHelper_ReportProgress;
    }

        public void Handle(MainOnEvent message)
        {
            if(message.State == 1)
            {
                previouslyActive = (Caliburn.Micro.Screen)ActiveItem;
                ActivateItem(_mainViewModel);
            }
        }

        #region Get&Set

        public bool DialogIsOpen
        {
            get { return dialogIsOpen; }
            set
            {
                dialogIsOpen = value;
                NotifyOfPropertyChange(() => DialogIsOpen);
                MenuIndex = 1;
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
        public int MenuIndex
        {
            get { return menuIndex; }
            set
            {
                menuIndex = value;
                NotifyOfPropertyChange(() => MenuIndex);
                if (menuIndex == 0)
                    DialogIsOpen = true;
            }
        }

        #endregion

        #region Button Handlers

        public bool CanGoBack
        {
            get
            {
                bool check = false;
                if (previouslyActive != null)
                    check = true;
                return check;
            }
        }

        public void GoBack()
        {
            ActivateItem(previouslyActive);
        }

        public bool CanSelectCompressedFile()
        {
            bool CanClick = true;
            return CanClick;
        }

        public void SelectCompressedFile()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                SelectCompressedFilePath = dialog.FileName;
                CheckIfPathValid();
            }
        }

        public bool CanSelectDecompresionOutputFolder()
        {
            bool CanClick = true;
            return CanClick;
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

        public bool CanSelectCourseFolder()
        {
            bool CanClick = true;
            return CanClick;
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
                providerHelper = new DataProviderHelper(SelectCompressedFilePath,SelectDecompresionOutputFolderPath,progress);
            }
            else if (FolderRadio)
            {
                providerHelper = new DataProviderHelper(SelectCourseFolderPath, progress);
            }
            fullCourse= await Task.Run(()=>providerHelper.GetFullCourse());
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
                ProgresVisibility = Visibility.Visible;
                StartLoadingVisibility = Visibility.Visible;
            }
            else
            {
                ProgresVisibility = Visibility.Collapsed;
                StartLoadingVisibility = Visibility.Collapsed;
            }
            CanStartLoading(isValid);
            return isValid;
        }

        private void ProviderHelper_ReportProgress(object sender, ReportDataProviderProgress e)
        {
           // Console.WriteLine(e.Percentage + "% " + e.Progress.Message);
            ProgressBar = e.Percentage;
        }
    }
}

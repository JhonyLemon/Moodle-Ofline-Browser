using Caliburn.Micro;
using Microsoft.Win32;
using Moodle_Ofline_Browser_Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class EnterBackupFileViewModel : Caliburn.Micro.Screen
    {
        private IEventAggregator _eventAggregator;
        private string FilePath = "";
        private string FolderPath = "";
        private string _path1 = "";
        private string _path2 = "";
        private FullCourse fullCourse;

        public string Path1
        {
            get { return _path1; }
            set 
            { 
                _path1 = value;
                NotifyOfPropertyChange(() => Path1);
            }
        }

        public string Path2
        {
            get { return _path2; }
            set 
            { 
                _path2 = value;
                NotifyOfPropertyChange(() => Path2);
            }
        }

        public EnterBackupFileViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }


        public void ChooseFile()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();

            if(dialog.ShowDialog() == true)
            {
                FilePath = dialog.FileName;
                Path1 = FilePath;
            }
        }

        public void ChooseFolder()
        {
            var dialog = new FolderBrowserDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = dialog.SelectedPath;
                Path2 = FolderPath;
            }
        }

        public void Extract()
        {
            if (FilePath.Length == 0 || FolderPath.Length == 0)
            {
                MessageBox.Show("Wybierz obie sciezki", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                fullCourse = Moodle_Ofline_Browser_Core.MbzDecompressor.Extract(FilePath, FolderPath);
            }
        }
    }
}

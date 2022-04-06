using Caliburn.Micro;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class EnterBackupFileViewModel : Screen
    {
        private IEventAggregator _eventAggregator;
        private String path;

        public EnterBackupFileViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void ChooseFile()
        {
            var dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == true)
            {
                path = dialog.FileName;
            }
        }
    }
}

using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        private IEventAggregator _eventAggregator;
        private EnterBackupFileViewModel _enterBackupFileViewModel;


        public ShellViewModel(IEventAggregator eventAggregator, EnterBackupFileViewModel enterBackupFileViewModel)
        {
            _eventAggregator = eventAggregator;
            _enterBackupFileViewModel = enterBackupFileViewModel;
            _eventAggregator.Subscribe(this);
            ActivateItem(_enterBackupFileViewModel);
        }
    }
}

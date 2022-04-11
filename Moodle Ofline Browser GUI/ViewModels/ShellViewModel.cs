using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.ViewModels;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class ShellViewModel : Conductor<object>, IHandle<MainOnEvent>
    {
        private IEventAggregator _eventAggregator;
        private EnterBackupFileViewModel _enterBackupFileViewModel;
        private MainViewModel _mainViewModel;
        private Screen previouslyActive;


        public ShellViewModel(IEventAggregator eventAggregator, EnterBackupFileViewModel enterBackupFileViewModel, MainViewModel mainViewModel)
        {
            _eventAggregator = eventAggregator;
            _enterBackupFileViewModel = enterBackupFileViewModel;
            _mainViewModel = mainViewModel;
            _eventAggregator.Subscribe(this);
            ActivateItem(_enterBackupFileViewModel);
        }

        public void Handle(MainOnEvent message)
        {
            if(message.State == 1)
            {
                previouslyActive = (Screen)ActiveItem;
                ActivateItem(_mainViewModel);
            }
        }
    }
}

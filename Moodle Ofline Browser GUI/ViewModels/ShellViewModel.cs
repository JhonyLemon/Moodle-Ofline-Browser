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
using System.Collections.ObjectModel;
using MaterialDesignThemes.Wpf;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class ShellViewModel : Conductor<object>, IHandle<CanClickAway>
    {
        private IEventAggregator _eventAggregator;
        private MainViewModel _mainViewModel;
        private DialogViewModel _dialogViewModel;
        private Caliburn.Micro.Screen previouslyActive;

        private bool dialogIsOpen;
        private bool canCloseOnClickAway;
        private int menuIndex;

        private FullCourse fullCourse;

        private Visibility goBackVisibility;


        public ShellViewModel(IEventAggregator eventAggregator, MainViewModel mainViewModel,DialogViewModel dialogViewModel)
        {
            _eventAggregator = eventAggregator;
            _mainViewModel = mainViewModel;
            _dialogViewModel = dialogViewModel;
            _eventAggregator.Subscribe(this);
            ActivateItem(_mainViewModel);

            MenuIndex = 1;
            GoBackVisibility = Visibility.Collapsed;
            CanCloseOnClickAway = true;
    }

        public void Handle(CanClickAway message)
        {
            CanCloseOnClickAway = message.CanClickAwayToClose;
        }
    
        public bool CanCloseOnClickAway
        {
            get { return canCloseOnClickAway; }
            set
            {
                canCloseOnClickAway = value;
                NotifyOfPropertyChange(() => CanCloseOnClickAway);
            }
        }
        public bool DialogIsOpen
        {
            get { return dialogIsOpen; }
            set
            {
                dialogIsOpen = value;
                NotifyOfPropertyChange(() => DialogIsOpen);
                if(!dialogIsOpen)
                {
                    MenuIndex = 1;
                    if (_dialogViewModel.IsNewData)
                    {
                        fullCourse = _dialogViewModel.FullCourse;
                        _eventAggregator.PublishOnUIThread(new CourseParsed(fullCourse));
                        ActivateItem(_mainViewModel);
                    }
                    _dialogViewModel.ClearDialogBox();
                }
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

        public int MenuIndex
        {
            get { return menuIndex; }
            set
            {
                menuIndex = value;
                NotifyOfPropertyChange(() => MenuIndex);
                if (menuIndex == 0)
                {
                    UIElement uiElement = ViewLocator.LocateForModel(_dialogViewModel, null, null);
                    ViewModelBinder.Bind(_dialogViewModel, uiElement, null);
                    DialogHost.Show(uiElement);
                }
                    
            }
        }

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

    }
}

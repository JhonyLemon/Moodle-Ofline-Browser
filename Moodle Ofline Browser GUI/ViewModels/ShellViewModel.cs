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
    class ShellViewModel : Conductor<object>, IHandle<CanClickAway>,IHandle<CourseParsed>
    {
        private IEventAggregator _eventAggregator;
        private MainViewModel _mainViewModel;
        private DialogViewModel _dialogViewModel;

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
                if (!DialogIsOpen)
                    MenuIndex = 1;
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
                switch (MenuIndex)
                { 
                    case 0://dialog
                        UIElement uiElement = ViewLocator.LocateForModel(_dialogViewModel, null, null);
                        ViewModelBinder.Bind(_dialogViewModel, uiElement, null);
                        DialogHost.Show(uiElement);
                        break;
                    case 1://lista
                        break;
                }                    
            }
        }

        public void GoBack()
        {
            
        }

        public void Handle(CourseParsed message)
        {
            DialogIsOpen = false;
            fullCourse = message.FullCourse;
            _dialogViewModel.ClearFields();
            _dialogViewModel.DefaultVisibility();
            ActivateItem(_mainViewModel);
        }
    }
}

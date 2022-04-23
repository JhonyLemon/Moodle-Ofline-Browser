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
using System.Windows.Media;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class ShellViewModel : Conductor<object>, IHandle<CanClickAway>,IHandle<CourseParsed>
    {
        private IEventAggregator _eventAggregator;
        private MainViewModel _mainViewModel;
        private DialogViewModel _dialogViewModel;

        private bool dialogIsOpen;
        private bool canCloseOnClickAway;
        private Brush treeViewIconColor;


        public ShellViewModel(IEventAggregator eventAggregator, MainViewModel mainViewModel,DialogViewModel dialogViewModel)
        {
            _eventAggregator = eventAggregator;
            _mainViewModel = mainViewModel;
            _dialogViewModel = dialogViewModel;
            _eventAggregator.Subscribe(this);
            ActivateItem(_mainViewModel);

            TreeViewIconColor = Brushes.Black;
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
            }
        }
 
        public Brush TreeViewIconColor
        {
            get { return treeViewIconColor; }
            set
            {
                treeViewIconColor = value;
                NotifyOfPropertyChange(() => TreeViewIconColor);                  
            }
        }

        public void OpenDialog()
        {
            if (!DialogIsOpen)
            {
                UIElement uiElement = ViewLocator.LocateForModel(_dialogViewModel, null, null);
                ViewModelBinder.Bind(_dialogViewModel, uiElement, null);
                DialogHost.Show(uiElement);
            }
        }

        public void TreeViewVisibility()
        {
            if(treeViewIconColor == Brushes.Black)
            {
                TreeViewIconColor = Brushes.White;
                _mainViewModel.TreeViewVisibility = Visibility.Collapsed;
            }
            else if(treeViewIconColor == Brushes.White)
            {
                TreeViewIconColor = Brushes.Black;
                _mainViewModel.TreeViewVisibility = Visibility.Visible;
            }
        }

        
        public void Handle(CourseParsed message)
        {
            DialogIsOpen = false;
            _dialogViewModel.ClearFields();
            _dialogViewModel.DefaultVisibility();
        }
    }
}

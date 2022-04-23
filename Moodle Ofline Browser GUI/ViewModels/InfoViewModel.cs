using Caliburn.Micro;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    internal class InfoViewModel : Screen, IHandle<InformSubView>
    {

        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> infos;
        private NameValuePair info;
        private Visibility openFileVisibility;

        public InfoViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            infos = new ObservableCollection<ModelCategory>();
            info = null;
        }

        public ObservableCollection<ModelCategory> Infos
        {
            get { return infos; }
            set
            {
                infos = value;
                NotifyOfPropertyChange(() => Infos);
            }
        }
        public Visibility OpenFileVisibility
        {
            get { return openFileVisibility; }
            set
            {
                openFileVisibility = value;
                NotifyOfPropertyChange(() => OpenFileVisibility);
            }
        }

        public NameValuePair Info
        {
            get { return info; }
            set
            {
                info = value;
                NotifyOfPropertyChange(() => Info);
            }
        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(InfoViewModel))
            {
                if (message.Category.SubCategories.Count > 0 && Infos != message.Category.SubCategories)
                {
                    Infos = message.Category.SubCategories;
                    if (((NameValuePair)Infos.Last()).Name == "Path:")
                        OpenFileVisibility = Visibility.Visible;
                    else
                        OpenFileVisibility = Visibility.Collapsed;
                }
                else if (message.Category.SubCategories.Count == 0 && message.Category is NameValuePair)
                {
                    Infos = new ObservableCollection<ModelCategory>() { (NameValuePair)message.Category };
                    OpenFileVisibility = Visibility.Collapsed;
                }
            }
        }

        public void OpenFile()
        {
            System.Diagnostics.Process.Start(((NameValuePair)Infos.Last()).Value);
        }


        public void InfoSelection()
        {
            if(Info!=null)
            _eventAggregator.PublishOnUIThread(new SubItemSelected(Info));
        }

    }
}

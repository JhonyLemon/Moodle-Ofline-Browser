using Caliburn.Micro;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.Interfaces;
using Moodle_Ofline_Browser_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class ActivitiesListViewModel: Screen,IHandle<InformSubView>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> activities;
        Activity activity;

        public ActivitiesListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            activities = new ObservableCollection<ModelCategory>();
            activity = null;
        }

        public ObservableCollection<ModelCategory> Activities
        {
            get { return activities; }
            set
            {
                activities = value;
                NotifyOfPropertyChange(() => Activities);
            }
        }

        public Activity Activity
        {
            get { return activity; }
            set
            {
                activity = value;
                NotifyOfPropertyChange(() => Activity);
            }
        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(ActivitiesListViewModel) && Activities!= message.Category.SubCategories)
                Activities = message.Category.SubCategories;
        }

        public void AcitivtySelection()
        {
            _eventAggregator.PublishOnUIThread(new SubItemSelected(Activity));
        }
    }
}

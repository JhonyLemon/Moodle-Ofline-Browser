using Caliburn.Micro;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.Helpers;
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
        private string column;
        private string direction;

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



        public void SortCol(string propName)
        {
            ObservableCollection<ModelCategory> temp;
            Activity activity = Activity;
            switch (propName)
            {
                case "Id":
                    {
                        if(column=="Id")
                        {
                            if(direction=="asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Activities.OrderByDescending(p => (p as Activity).Id));
                                Activities.Clear();
                                foreach (ModelCategory j in temp) Activities.Add(j);
                                
                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Activities.OrderBy(p => (p as Activity).Id));
                                Activities.Clear();
                                foreach (ModelCategory j in temp) Activities.Add(j);
                            }
                        }
                        else
                        {
                            column = "Id";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Activities.OrderBy(p => (p as Activity).Id));
                            Activities.Clear();
                            foreach (ModelCategory j in temp) Activities.Add(j);
                        }
                        break;
                    }
                case "Name":
                    {
                        if (column == "Name")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Activities.OrderByDescending(p => (p as Activity).Name));
                                Activities.Clear();
                                foreach (ModelCategory j in temp) Activities.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Activities.OrderBy(p => (p as Activity).Name));
                                Activities.Clear();
                                foreach (ModelCategory j in temp) Activities.Add(j);
                            }
                        }
                        else
                        {
                            column = "Name";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Activities.OrderBy(p => (p as Activity).Name));
                            Activities.Clear();
                            foreach (ModelCategory j in temp) Activities.Add(j);
                        }
                        break;
                    }
                case "Type":
                    {
                        if (column == "Type")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Activities.OrderByDescending(p => (p as Activity).Type));
                                Activities.Clear();
                                foreach (ModelCategory j in temp) Activities.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Activities.OrderBy(p => (p as Activity).Type));
                                Activities.Clear();
                                foreach (ModelCategory j in temp) Activities.Add(j);
                            }
                        }
                        else
                        {
                            column = "Type";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Activities.OrderBy(p => (p as Activity).Type));
                            Activities.Clear();
                            foreach (ModelCategory j in temp) Activities.Add(j);
                        }
                        break;
                    }
            }
            Activity = activity;
        }
    }
}

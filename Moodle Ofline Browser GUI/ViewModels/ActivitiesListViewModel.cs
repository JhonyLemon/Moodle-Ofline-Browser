using Caliburn.Micro;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class ActivitiesListViewModel: Screen,IHandle<CourseParsed>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<Activity> activities;
        private Moodle_Ofline_Browser_Core.models.FullCourse fullCourse;
        Activity activity;

        public ActivitiesListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            activities = new ObservableCollection<Activity>();
            activity = null;
        }

        public ObservableCollection<Activity> Activities
        {
            get { return activities; }
            set
            {
                activities = value;
                NotifyOfPropertyChange(() => Activities);
            }
        }

        public Moodle_Ofline_Browser_Core.models.FullCourse FullCourse
        {
            set
            {
                fullCourse = value;
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

        public void Handle(CourseParsed message)
        {
            FullCourse = message.FullCourse;
            Activities.Clear();
            foreach (KeyValuePair<int, Moodle_Ofline_Browser_Core.models.activities.ActivityFolder> activity in fullCourse.ActivitiesFolder)
            {
                if (activity.Value.ActivityType != null)
                {
                    Models.Activity _activity = new Activity();
                    _activity.Id = activity.Value.ActivityType.Id;
                    _activity.Type = activity.Value.ActivityType.Modulename;


                    switch (activity.Value.ActivityType.Modulename)
                    {
                        case "attendance":
                            _activity.Name = ((Moodle_Ofline_Browser_Core.models.activities.activityTypes.attendance.Attendance)activity.Value.ActivityType.ActivityType).Name;
                            break;
                        case "assign":
                            _activity.Name = ((Moodle_Ofline_Browser_Core.models.activities.activityTypes.assign.Assign)activity.Value.ActivityType.ActivityType).Name;
                            break;
                        case "chat":
                            break;
                        case "quiz":
                            break;
                        default:
                            break;
                    }
                    Activities.Add(_activity);
                }
            }
        }

        public void ActivitySelection()
        {

        }
    }
}

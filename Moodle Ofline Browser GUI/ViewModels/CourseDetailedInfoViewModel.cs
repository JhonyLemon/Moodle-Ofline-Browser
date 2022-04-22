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
    class CourseDetailedInfoViewModel : Screen,IHandle<InformSubView>
    {

        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> courseInfos;
        NameValuePair courseInfo;

        public CourseDetailedInfoViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            courseInfos = new ObservableCollection<ModelCategory>();
            courseInfo = null;
        }

        public ObservableCollection<ModelCategory> CourseInfos
        {
            get { return courseInfos; }
            set
            {
                courseInfos = value;
                NotifyOfPropertyChange(() => CourseInfos);
            }
        }

        public NameValuePair CourseInfo
        {
            get { return courseInfo; }
            set
            {
                courseInfo = value;
                NotifyOfPropertyChange(() => CourseInfo);
            }
        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(CourseDetailedInfoViewModel))
                CourseInfos = message.Category.SubCategories;
        }
    }
}

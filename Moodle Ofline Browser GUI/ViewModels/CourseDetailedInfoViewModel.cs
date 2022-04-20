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
    class CourseDetailedInfoViewModel : Screen,IHandle<CourseParsed>
    {

        private IEventAggregator _eventAggregator;

        private ObservableCollection<CourseInfo> courseInfos;
        private Moodle_Ofline_Browser_Core.models.FullCourse fullCourse;
        CourseInfo courseInfo;

        public CourseDetailedInfoViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            courseInfos = new ObservableCollection<CourseInfo>();
            courseInfo = null;
        }

        public ObservableCollection<CourseInfo> CourseInfos
        {
            get { return courseInfos; }
            set
            {
                courseInfos = value;
                NotifyOfPropertyChange(() => CourseInfos);
            }
        }

        public Moodle_Ofline_Browser_Core.models.FullCourse FullCourse
        {
            set
            {
                fullCourse = value;
            }
        }

        public CourseInfo CourseInfo
        {
            get { return courseInfo; }
            set
            {
                courseInfo = value;
                NotifyOfPropertyChange(() => CourseInfo);
            }
        }

        public void Handle(CourseParsed message)
        {
            FullCourse = message.FullCourse;
            CourseInfos.Clear();
            
            foreach (System.Reflection.PropertyInfo prop in typeof(Moodle_Ofline_Browser_Core.models.course.Course).GetProperties())
            {

                if(prop.GetValue(fullCourse.Course.Course, null) is string)
                    CourseInfos.Add(new CourseInfo(prop.Name, (string)prop.GetValue(fullCourse.Course.Course, null)));
            }
        }
        public void CourseInfoSelection()
        {

        }

    }
}

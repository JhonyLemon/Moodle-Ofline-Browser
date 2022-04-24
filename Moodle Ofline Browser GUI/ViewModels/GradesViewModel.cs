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
    public class GradesViewModel : Screen, IHandle<InformSubView>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> grades;
        Grade grade;

        public GradesViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            grades = new ObservableCollection<ModelCategory>();
            grade = null;
        }

        public ObservableCollection<ModelCategory> Grades
        {
            get { return grades; }
            set
            {
                grades = value;
                NotifyOfPropertyChange(() => Grades);
            }
        }

        public Grade Grade
        {
            get { return grade; }
            set
            {
                grade = value;
                NotifyOfPropertyChange(() => Grade);
            }
        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(GradesViewModel) && Grades != message.Category.SubCategories)
                Grades = message.Category.SubCategories;
        }

        public void GradeSelection()
        {
            _eventAggregator.PublishOnUIThread(new SubItemSelected(Grade));
        }
    }
}

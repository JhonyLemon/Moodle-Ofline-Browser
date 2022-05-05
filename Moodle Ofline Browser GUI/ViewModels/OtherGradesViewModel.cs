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
    public class OtherGradesViewModel : Screen, IHandle<InformSubView>, IHandle<FontChanged>, IHandle<GradeVisibility>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> grades;
        private ObservableCollection<ModelCategory> gradesFull;
        private bool showMoodleGrades;
        Grade grade;
        private string column;
        private string direction;

        public OtherGradesViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            gradesFull = new ObservableCollection<ModelCategory>();
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

        private int fontSize;
        public int FontSize
        {
            get { return fontSize; }
            set
            {
                fontSize = value;
                NotifyOfPropertyChange(() => FontSize);
            }
        }

        public void Handle(FontChanged message)
        {
            FontSize = message.FontSize;
        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(OtherGradesViewModel) && Grades != message.Category.SubCategories)
            {
                gradesFull = message.Category.SubCategories;
                ChangeGrades(ShowMoodleGrades);
            }
        }

        public void GradeSelection()
        {
            _eventAggregator.PublishOnUIThread(new SubItemSelected(Grade));
        }


        public bool ShowMoodleGrades
        {
            get { return showMoodleGrades; }
            set
            {
                showMoodleGrades = value;
                ChangeGrades(ShowMoodleGrades);
            }
        }
        public void ChangeGrades(bool value)
        {
            if (value)
            {
                Grades.Clear();
                foreach (ModelCategory j in gradesFull) Grades.Add(j);
            }
            else
            {
                Grades.Clear();
                foreach (ModelCategory j in gradesFull)
                {
                    if ((j as Grade).GradeValue != "$@NULL@$")
                        Grades.Add(j);
                }
            }
        }

        public void Handle(GradeVisibility message)
        {
            ShowMoodleGrades = message.IsVisible;
        }


        public void SortCol(string propName)
        {
            ObservableCollection<ModelCategory> temp;
            Grade grade = Grade;
            switch (propName)
            {
                case "Date":
                    {
                        if (column == "Date")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Grades.OrderByDescending(p => (p as Grade).Date));
                                Grades.Clear();
                                foreach (ModelCategory j in temp) Grades.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Grades.OrderBy(p => (p as Grade).Date));
                                Grades.Clear();
                                foreach (ModelCategory j in temp) Grades.Add(j);
                            }
                        }
                        else
                        {
                            column = "Date";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Grades.OrderBy(p => (p as Grade).Date));
                            Grades.Clear();
                            foreach (ModelCategory j in temp) Grades.Add(j);
                        }
                        break;
                    }

                case "User":
                    {
                        if (column == "User")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Grades.OrderByDescending(p => (p as Grade).User));
                                Grades.Clear();
                                foreach (ModelCategory j in temp) Grades.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Grades.OrderBy(p => (p as Grade).User));
                                Grades.Clear();
                                foreach (ModelCategory j in temp) Grades.Add(j);
                            }
                        }
                        else
                        {
                            column = "User";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Grades.OrderBy(p => (p as Grade).User));
                            Grades.Clear();
                            foreach (ModelCategory j in temp) Grades.Add(j);
                        }
                        break;
                    }
                case "GradeValue":
                    {
                        if (column == "GradeValue")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Grades.OrderByDescending(p => (p as Grade).GradeValue));
                                Grades.Clear();
                                foreach (ModelCategory j in temp) Grades.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Grades.OrderBy(p => (p as Grade).GradeValue));
                                Grades.Clear();
                                foreach (ModelCategory j in temp) Grades.Add(j);
                            }
                        }
                        else
                        {
                            column = "GradeValue";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Grades.OrderBy(p => (p as Grade).GradeValue));
                            Grades.Clear();
                            foreach (ModelCategory j in temp) Grades.Add(j);
                        }
                        break;
                    }
            }
            Grade = grade;
        }
    }
}

using Caliburn.Micro;
using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.Models;
using System.Collections.Generic;
using System.Windows;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class MainViewModel : Screen, IHandle<CourseParsed>
    {
        private List<Category> categoryItems;

        private IEventAggregator _eventAggregator;
        private UsersListViewModel _usersListViewModel;
        private FilesListViewModel _filesListViewModel;
        private CourseDetailedInfoViewModel _courseDetailedInfoViewModel;
        private ActivitiesListViewModel _activitiesListViewModel;

        private Screen activeList;

        private Visibility noDataVisibility;
        private string currentlyLoadedCourse;
        private FullCourse fullCourse;
        private Category categoryItem;

        public MainViewModel(IEventAggregator eventAggregator, 
            UsersListViewModel usersListViewModel, 
            ActivitiesListViewModel activitiesListViewModel,
            CourseDetailedInfoViewModel courseDetailedInfoViewModel,
            FilesListViewModel filesListViewModel)
        {
            _eventAggregator = eventAggregator;
            _usersListViewModel = usersListViewModel;
            _activitiesListViewModel = activitiesListViewModel;
            _filesListViewModel = filesListViewModel;
            _courseDetailedInfoViewModel = courseDetailedInfoViewModel;

            this._eventAggregator.Subscribe(this);

            UIElement uiElement;
            uiElement = ViewLocator.LocateForModel(_usersListViewModel, null, null);
            ViewModelBinder.Bind(_usersListViewModel, uiElement, null);

            uiElement = ViewLocator.LocateForModel(_activitiesListViewModel, null, null);
            ViewModelBinder.Bind(_activitiesListViewModel, uiElement, null);

            uiElement = ViewLocator.LocateForModel(_filesListViewModel, null, null);
            ViewModelBinder.Bind(_filesListViewModel, uiElement, null);


            categoryItems = new List<Category>()
            {
                new Category("Użytkownicy",1),
                new Category("Aktywności",2),
                new Category("Pliki",3),
                new Category("Kurs",4)
            };
        }
        
        public FullCourse FullCourse
        {
            get { return fullCourse; }
            set
            {
                    fullCourse = value;
            }
        }

        public Screen ActiveList
        {
            get { return activeList; }
            set
            {
                activeList = value;
                NotifyOfPropertyChange(() => ActiveList);
            }
        }
        

        public string CurrentlyLoadedCourse
        {
            get { return currentlyLoadedCourse; }
            set
            {
                currentlyLoadedCourse = value;
                NotifyOfPropertyChange(() => CurrentlyLoadedCourse);
            }
        }

        public List<Category> CategoryItems 
        {
            get { return categoryItems; }
            set
            {
                categoryItems = value;
                NotifyOfPropertyChange(() => CategoryItems);
            }
        }

        public Visibility NoDataVisibility
        {
            get { return noDataVisibility; }
            set
            {
                noDataVisibility = value;
                NotifyOfPropertyChange(() => NoDataVisibility);
            }
        }
        public Category CategoryItem
        {
            get { return categoryItem; }
            set
            {
                categoryItem = value;
                NotifyOfPropertyChange(() => CategoryItem);
                switch (CategoryItem.Id)
                {
                    case 1:
                        ActiveList =_usersListViewModel;
                        break;
                    case 2:
                        ActiveList = _activitiesListViewModel;
                        break;
                    case 3:
                        ActiveList = _filesListViewModel;
                        break;
                    case 4:
                        ActiveList = _courseDetailedInfoViewModel;
                        break;
                    default:
                        break;
                }
            }
        }

        public void Handle(CourseParsed message)
        {
            NoDataVisibility = Visibility.Collapsed;
            FullCourse = message.FullCourse;
            CurrentlyLoadedCourse = fullCourse.Course.Course.Fullname;
        }
    }
}

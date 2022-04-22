using Caliburn.Micro;
using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_GUI.EventModels;
using Moodle_Ofline_Browser_GUI.Helpers;
using Moodle_Ofline_Browser_GUI.Interfaces;
using Moodle_Ofline_Browser_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class MainViewModel : Screen, IHandle<CourseParsed>,IHandle<SubItemSelected>
    {
        private ObservableCollection<ModelCategory> categoryItems;

        private IEventAggregator _eventAggregator;
        private UsersListViewModel _usersListViewModel;
        private FilesListViewModel _filesListViewModel;
        private FileInfoViewModel _fileInfoViewModel;
        private CourseDetailedInfoViewModel _courseDetailedInfoViewModel;
        private ActivitiesListViewModel _activitiesListViewModel;

        private Screen activeList;

        private Visibility noDataVisibility;
        private string currentlyLoadedCourse;
        private FullCourse fullCourse;

        public MainViewModel(IEventAggregator eventAggregator, 
            UsersListViewModel usersListViewModel, 
            ActivitiesListViewModel activitiesListViewModel,
            CourseDetailedInfoViewModel courseDetailedInfoViewModel,
            FileInfoViewModel fileInfoViewModel,
            FilesListViewModel filesListViewModel)
        {
            _eventAggregator = eventAggregator;
            _usersListViewModel = usersListViewModel;
            _activitiesListViewModel = activitiesListViewModel;
            _filesListViewModel = filesListViewModel;
            _fileInfoViewModel = fileInfoViewModel;
            _courseDetailedInfoViewModel = courseDetailedInfoViewModel;

            this._eventAggregator.Subscribe(this);

            categoryItems = new ObservableCollection<ModelCategory>();
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

        public ObservableCollection<ModelCategory> CategoryItems 
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

        public void SetSelectedType(ModelCategory item)
        {
            ActiveList = (Screen)item.FieldInfo.GetValue(this);
            _eventAggregator.PublishOnUIThread(new InformSubView(item));
        }

        public void Handle(CourseParsed message)
        {
            NoDataVisibility = Visibility.Collapsed;
            FullCourse = message.FullCourse;
            CategoryItems.Clear();
            CurrentlyLoadedCourse = fullCourse.Course.Course.Fullname;

            CategoriesCreatorHelper helper = new CategoriesCreatorHelper(FullCourse);
            helper.LoadToCategories();
            CategoryItems = helper.CategoryItems;

            //_eventAggregator.PublishOnUIThread(new CategoriesCreated(CategoryItems));
        }



        public void Handle(SubItemSelected message)
        {
            SetSelectedType(message.Category);
        }
    }
}

using Caliburn.Micro;
using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_GUI.Models;
using System.Collections.Generic;
using System.Windows;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    class MainViewModel : Screen
    {
        private List<Category> categoryItems;
        private IEventAggregator _eventAggregator;
        private Visibility noDataVisibility;
        private FullCourse fullCourse;
        private Category categoryItem;

        public MainViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
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
            }
        }
    }
}

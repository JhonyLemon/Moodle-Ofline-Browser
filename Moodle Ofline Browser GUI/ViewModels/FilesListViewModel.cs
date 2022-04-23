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
    class FilesListViewModel : Screen, IHandle<InformSubView>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> files;
        File file;

        public FilesListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
            files = new ObservableCollection<ModelCategory>();
            file = null;
        }

        public ObservableCollection<ModelCategory> Files
        {
            get { return files; }
            set
            {
                files = value;
                NotifyOfPropertyChange(() => Files);
            }
        }
        public File File
        {
            get { return file; }
            set
            {
                file = value;
                NotifyOfPropertyChange(() => File);
            }
        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(FilesListViewModel) && Files != message.Category.SubCategories)
                Files = message.Category.SubCategories;
        }

        public void FileSelection()
        {
            _eventAggregator.PublishOnUIThread(new SubItemSelected(File));
        }

    }
}

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
    public class FileInfoViewModel : Screen,IHandle<InformSubView>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> fileInfo;

        public FileInfoViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            fileInfo = new ObservableCollection<ModelCategory>();
        }

        public ObservableCollection<ModelCategory> FileInfo
        {
            get { return fileInfo; }
            set
            {
                fileInfo = value;
                NotifyOfPropertyChange(() => FileInfo);
            }
        }

        public void FileOpen()
        {

        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(FileInfoViewModel))
                FileInfo = message.Category.SubCategories;
        }
    }
}

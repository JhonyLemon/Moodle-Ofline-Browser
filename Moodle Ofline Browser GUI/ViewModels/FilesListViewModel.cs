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
    class FilesListViewModel : Screen, IHandle<CourseParsed>
    {

        private IEventAggregator _eventAggregator;

        private ObservableCollection<File> files;
        private Moodle_Ofline_Browser_Core.models.FullCourse fullCourse;
        File file;

        public FilesListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            files = new ObservableCollection<File>();
            file = null;
        }

        public ObservableCollection<File> Files
        {
            get { return files; }
            set
            {
                files = value;
                NotifyOfPropertyChange(() => Files);
            }
        }

        public Moodle_Ofline_Browser_Core.models.FullCourse FullCourse
        {
            set
            {
                fullCourse = value;
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

        public void Handle(CourseParsed message)
        {
            FullCourse = message.FullCourse;
            Files.Clear();
            foreach (Moodle_Ofline_Browser_Core.models.files.File file in fullCourse.Files.File)
            {
                File _file = new File();
                _file.Id = file.Id;
                _file.FileName = file.Filename;
                foreach (Moodle_Ofline_Browser_Core.models.users.User user in fullCourse.Users.User)
                {
                   if(user.Id==file.Userid)
                    {
                        _file.User = user.Firstname + " " + user.Lastname;
                        break;
                    }
                }
                _file.Date=DateTimeOffset.FromUnixTimeSeconds(file.Timecreated).ToString("G");
                Files.Add(_file);
            }
        }

        public void FileSelection()
        {

        }

    }
}

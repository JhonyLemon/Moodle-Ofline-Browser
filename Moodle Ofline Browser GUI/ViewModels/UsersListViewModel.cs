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
    class UsersListViewModel :Screen,IHandle<CourseParsed>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<User> users;
        private Moodle_Ofline_Browser_Core.models.FullCourse fullCourse;
        User user;

        public UsersListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            users = new ObservableCollection<User>();
            user = null;
        }

        public ObservableCollection<User> Users
        {
            get { return users; }
            set
            {
                users = value;
                NotifyOfPropertyChange(() => Users);
            }
        }

        public Moodle_Ofline_Browser_Core.models.FullCourse FullCourse
        {
            set
            {
                fullCourse = value;
            }
        }

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                NotifyOfPropertyChange(() => User);
            }
        }

        public void Handle(CourseParsed message)
        {
            FullCourse = message.FullCourse;
            Users.Clear();
            foreach (Moodle_Ofline_Browser_Core.models.users.User user in fullCourse.Users.User)
            {
                Users.Add(new User(user.Id, user.Firstname, user.Lastname, user.Email));
            }
        }

        public void UserSelection()
        {

        }

    }
}

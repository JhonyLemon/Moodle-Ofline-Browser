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
    class UsersListViewModel :Screen,IHandle<InformSubView>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> users;
        User user;

        public UsersListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            users = new ObservableCollection<ModelCategory>();
            user = null;
        }

        public ObservableCollection<ModelCategory> Users
        {
            get { return users; }
            set
            {
                users = value;
                NotifyOfPropertyChange(() => Users);
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

        public void Handle(InformSubView message)
        {
            if(message.Category.FieldInfo.FieldType==typeof(UsersListViewModel) && Users != message.Category.SubCategories)
                Users = message.Category.SubCategories;
        }

        public void UserSelection()
        {

        }

    }
}

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
    class UsersListViewModel :Screen,IHandle<InformSubView>, IHandle<FontChanged>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> users;
        User user;
        private string column;
        private string direction;

        public UsersListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            users = new ObservableCollection<ModelCategory>();
            user = null;
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
            if (User != null)
                _eventAggregator.PublishOnUIThread(new SubItemSelected(User));
        }


        public void SortCol(string propName)
        {
            ObservableCollection<ModelCategory> temp;
            User user = User;
            switch (propName)
            {
                case "Id":
                    {
                        if (column == "Id")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Users.OrderByDescending(p => (p as User).Id));
                                Users.Clear();
                                foreach (ModelCategory j in temp) Users.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Users.OrderBy(p => (p as User).Id));
                                Users.Clear();
                                foreach (ModelCategory j in temp) Users.Add(j);
                            }
                        }
                        else
                        {
                            column = "Id";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Users.OrderBy(p => (p as User).Id));
                            Users.Clear();
                            foreach (ModelCategory j in temp) Users.Add(j);
                        }
                        break;
                    }
                case "FirstName":
                    {
                        if (column == "FirstName")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Users.OrderByDescending(p => (p as User).FirstName));
                                Users.Clear();
                                foreach (ModelCategory j in temp) Users.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Users.OrderBy(p => (p as User).FirstName));
                                Users.Clear();
                                foreach (ModelCategory j in temp) Users.Add(j);
                            }
                        }
                        else
                        {
                            column = "FirstName";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Users.OrderBy(p => (p as User).FirstName));
                            Users.Clear();
                            foreach (ModelCategory j in temp) Users.Add(j);
                        }
                        break;
                    }
                case "Surname":
                    {
                        if (column == "Surname")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Users.OrderByDescending(p => (p as User).Surname));
                                Users.Clear();
                                foreach (ModelCategory j in temp) Users.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Users.OrderBy(p => (p as User).Surname));
                                Users.Clear();
                                foreach (ModelCategory j in temp) Users.Add(j);
                            }
                        }
                        else
                        {
                            column = "Surname";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Users.OrderBy(p => (p as User).Surname));
                            Users.Clear();
                            foreach (ModelCategory j in temp) Users.Add(j);
                        }
                        break;
                    }
                case "Email":
                    {
                        if (column == "Email")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Users.OrderByDescending(p => (p as User).Email));
                                Users.Clear();
                                foreach (ModelCategory j in temp) Users.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Users.OrderBy(p => (p as User).Email));
                                Users.Clear();
                                foreach (ModelCategory j in temp) Users.Add(j);
                            }
                        }
                        else
                        {
                            column = "Email";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Users.OrderBy(p => (p as User).Email));
                            Users.Clear();
                            foreach (ModelCategory j in temp) Users.Add(j);
                        }
                        break;
                    }
            }
            User = user;
        }

    }
}

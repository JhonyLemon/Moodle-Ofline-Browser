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
    class FilesListViewModel : Screen, IHandle<InformSubView>, IHandle<FontChanged>,IHandle<FileVisibility>
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> files;
        private ObservableCollection<ModelCategory> filesFull;
        private bool showMoodleFiles;
        File file;
        private string column;
        private string direction;

        public FilesListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
            files = new ObservableCollection<ModelCategory>();
            filesFull = new ObservableCollection<ModelCategory>();
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
        public File File
        {
            get { return file; }
            set
            {
                file = value;
                NotifyOfPropertyChange(() => File);
            }
        }
        public bool ShowMoodleFiles
        {
            get { return showMoodleFiles; }
            set
            {
                showMoodleFiles = value;
                ChangeFiles(showMoodleFiles);
            }
        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(FilesListViewModel) && Files != message.Category.SubCategories)
            {
                filesFull = message.Category.SubCategories;
                ChangeFiles(ShowMoodleFiles);
            }
        }

        public void FileSelection()
        {
            _eventAggregator.PublishOnUIThread(new SubItemSelected(File));
        }

        public void ChangeFiles(bool value)
        {
            if(value)
            {
                Files.Clear();
                foreach (ModelCategory j in filesFull) Files.Add(j);
            }
            else
            {
                Files.Clear();
                foreach (ModelCategory j in filesFull)
                {
                    if((j as File).User!="")
                     Files.Add(j);
                }
            }
        }
        public void Handle(FileVisibility message)
        {
            ShowMoodleFiles = message.IsVisible;
        }

        public void SortCol(string propName)
        {
            ObservableCollection<ModelCategory> temp;
            File file = File;
            switch (propName)
            {
                case "Id":
                    {
                        if (column == "Id")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Files.OrderByDescending(p => (p as File).Id));
                                Files.Clear();
                                foreach (ModelCategory j in temp) Files.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Files.OrderBy(p => (p as File).Id));
                                Files.Clear();
                                foreach (ModelCategory j in temp) Files.Add(j);
                            }
                        }
                        else
                        {
                            column = "Id";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Files.OrderBy(p => (p as File).Id));
                            Files.Clear();
                            foreach (ModelCategory j in temp) Files.Add(j);
                        }
                        break;
                    }
                case "FileName":
                    {
                        if (column == "FileName")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Files.OrderByDescending(p => (p as File).FileName));
                                Files.Clear();
                                foreach (ModelCategory j in temp) Files.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Files.OrderBy(p => (p as File).FileName));
                                Files.Clear();
                                foreach (ModelCategory j in temp) Files.Add(j);
                            }
                        }
                        else
                        {
                            column = "FileName";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Files.OrderBy(p => (p as File).FileName));
                            Files.Clear();
                            foreach (ModelCategory j in temp) Files.Add(j);
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
                                temp = new ObservableCollection<ModelCategory>(Files.OrderByDescending(p => (p as File).User));
                                Files.Clear();
                                foreach (ModelCategory j in temp) Files.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Files.OrderBy(p => (p as File).User));
                                Files.Clear();
                                foreach (ModelCategory j in temp) Files.Add(j);
                            }
                        }
                        else
                        {
                            column = "User";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Files.OrderBy(p => (p as File).User));
                            Files.Clear();
                            foreach (ModelCategory j in temp) Files.Add(j);
                        }
                        break;
                    }
                case "Date":
                    {
                        if (column == "Date")
                        {
                            if (direction == "asc")
                            {
                                direction = "desc";
                                temp = new ObservableCollection<ModelCategory>(Files.OrderByDescending(p => (p as File).Date));
                                Files.Clear();
                                foreach (ModelCategory j in temp) Files.Add(j);

                            }
                            else
                            {
                                direction = "asc";
                                temp = new ObservableCollection<ModelCategory>(Files.OrderBy(p => (p as File).Date));
                                Files.Clear();
                                foreach (ModelCategory j in temp) Files.Add(j);
                            }
                        }
                        else
                        {
                            column = "Date";
                            direction = "asc";
                            temp = new ObservableCollection<ModelCategory>(Files.OrderBy(p => (p as File).Date));
                            Files.Clear();
                            foreach (ModelCategory j in temp) Files.Add(j);
                        }
                        break;
                    }
            }
            File = file;
        }
    }
}

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
    internal class SinglePropertyListViewModel : Screen, IHandle<InformSubView>
    {

        private IEventAggregator _eventAggregator;

        private ObservableCollection<ModelCategory> singlePropertyList;
        NameValuePair singlePropertySelectedItem;

        public SinglePropertyListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            this._eventAggregator.Subscribe(this);
            SinglePropertyList = new ObservableCollection<ModelCategory>();
            SinglePropertySelectedItem = null;
        }

        public ObservableCollection<ModelCategory> SinglePropertyList
        {
            get { return singlePropertyList; }
            set
            {
                singlePropertyList = value;
                NotifyOfPropertyChange(() => SinglePropertyList);
            }
        }

        public NameValuePair SinglePropertySelectedItem
        {
            get { return singlePropertySelectedItem; }
            set
            {
                singlePropertySelectedItem = value;
                NotifyOfPropertyChange(() => SinglePropertySelectedItem);
            }
        }

        public void Handle(InformSubView message)
        {
            if (message.Category.FieldInfo.FieldType == typeof(SinglePropertyListViewModel) && SinglePropertyList != message.Category.SubCategories)
            {
                SinglePropertyList.Clear();
                SinglePropertyList.Add(((NameValuePair)message.Category));
            }
        }
    }
}

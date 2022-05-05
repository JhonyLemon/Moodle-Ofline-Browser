using Caliburn.Micro;
using Moodle_Ofline_Browser_GUI.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    public class AboutViewModel : Caliburn.Micro.Screen,IHandle<FontChanged>
    {
        private IEventAggregator _eventAggregator;

        public AboutViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
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
    }
}

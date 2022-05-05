using Caliburn.Micro;
using Moodle_Ofline_Browser_GUI.EventModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.ViewModels
{
    public class FontDetailsViewModel : Caliburn.Micro.Screen,IHandle<FontChanged>
    {
        private IEventAggregator _eventAggregator;
        private int fontSize;
        private int font;

        public FontDetailsViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
            Font = 13;
        }
        public int FontSize
        {
            get { return fontSize; }
            set
            {
                    fontSize = value;
                    NotifyOfPropertyChange(() => FontSize);
            }
        }
        public int Font
        {
            get { return font; }
            set
            {
                font = value;
                NotifyOfPropertyChange(() => Font);
                if (Font >= 13 && Font <= 36)
                {
                    _eventAggregator.PublishOnUIThread(new FontChanged(Font));
                }
            }
        }

        public void Handle(FontChanged message)
        {
            FontSize = message.FontSize;
        }
    }
}

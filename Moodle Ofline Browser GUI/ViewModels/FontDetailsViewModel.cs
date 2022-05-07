using Caliburn.Micro;
using MaterialDesignThemes.Wpf;
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
        private PackIconKind moodleFileVisibility;
        private PackIconKind moodleGradeVisibility;
        private int font;
        private bool isDark;
        private readonly PaletteHelper _paletteHelper = new PaletteHelper();

        public FontDetailsViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
            Font = 13;
            MoodleFileVisibility = PackIconKind.Visibility;
            MoodleGradeVisibility = PackIconKind.Visibility;
            isDark = false;
            MoodleFilesVisibility();
            MoodleGradesVisibility();
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
        public PackIconKind MoodleFileVisibility
        {
            get { return moodleFileVisibility; }
            set
            {
                moodleFileVisibility = value;
                NotifyOfPropertyChange(() => MoodleFileVisibility);
            }
        }

        public void MoodleFilesVisibility()
        {
            if (MoodleFileVisibility == PackIconKind.Visibility)
            {
                MoodleFileVisibility = PackIconKind.VisibilityOff;
                _eventAggregator.PublishOnUIThread(new FileVisibility(false));
                //_mainViewModel.SetMoodleFileVisibility(false);
            }
            else if (MoodleFileVisibility == PackIconKind.VisibilityOff)
            {
                MoodleFileVisibility = PackIconKind.Visibility;
                _eventAggregator.PublishOnUIThread(new FileVisibility(true));
                //_mainViewModel.SetMoodleFileVisibility(true);
            }
        }

        
        public void ThemeSelection()
        {
            if (isDark)
                isDark = false;
            else
                isDark = true;
            ITheme theme = _paletteHelper.GetTheme();
            IBaseTheme baseTheme = isDark ? new MaterialDesignDarkTheme() : (IBaseTheme)new MaterialDesignLightTheme();
            theme.SetBaseTheme(baseTheme);
            _paletteHelper.SetTheme(theme);
        }

        public PackIconKind MoodleGradeVisibility
        {
            get { return moodleGradeVisibility; }
            set
            {
                moodleGradeVisibility = value;
                NotifyOfPropertyChange(() => MoodleGradeVisibility);
            }
        }

        public void MoodleGradesVisibility()
        {
            if (MoodleGradeVisibility == PackIconKind.Visibility)
            {
                MoodleGradeVisibility = PackIconKind.VisibilityOff;
                _eventAggregator.PublishOnUIThread(new GradeVisibility(false));
                //_mainViewModel.SetMoodleFileVisibility(false);
            }
            else if (MoodleGradeVisibility == PackIconKind.VisibilityOff)
            {
                MoodleGradeVisibility = PackIconKind.Visibility;
                //_mainViewModel.SetMoodleFileVisibility(true);
                _eventAggregator.PublishOnUIThread(new GradeVisibility(true));
            }
        }

        public void Handle(FontChanged message)
        {
            FontSize = message.FontSize;
        }
    }
}

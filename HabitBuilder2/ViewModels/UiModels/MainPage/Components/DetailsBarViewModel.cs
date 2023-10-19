using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components
{
    class DetailsBarViewModel : BaseViewModel
    {
        private string _title;
        private int _metric1 { get; set; }  // Can represent Level, CompletedThisWeek, etc.
        private int _metric2 { get; set; } // Can represent ExperiencePoints or something else

        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }

     


        public int Metric1
        {
            get => _metric1;
            set
            {
                if (_metric1 != value)
                {
                    _metric1 = value;
                    OnPropertyChanged();
                }
            }
        }

   
        public int Metric2
        {
            get => _metric2;
            set
            {
                if (_metric2 != value)
                {
                    _metric2 = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}

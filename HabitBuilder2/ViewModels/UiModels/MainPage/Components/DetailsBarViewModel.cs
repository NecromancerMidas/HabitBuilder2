using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.ViewModels.MainPage.Components
{
    class DetailsBarViewModel : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;



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


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}

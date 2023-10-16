using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.ViewModels.Templates
{
    public class WeekViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<DayViewModel> _days;
        public int ActiveHabits => _days.Count(d => d.Active);
        public int CompletedHabits => _days.Count(d => d.Completed);

        public WeekViewModel(Week week)
        {
            _days = new ObservableCollection<DayViewModel>(week.Days.Select(d => new DayViewModel(d)));
        }
        public ObservableCollection<DayViewModel> Days
        {
            get => _days;
            set
            {
                if (Equals(value, _days)) return;
                _days = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

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

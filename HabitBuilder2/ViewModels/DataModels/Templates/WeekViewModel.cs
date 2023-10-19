using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.DataModels.Templates
{
    public class WeekViewModel : BaseViewModel
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
            set => SetField(ref _days, value);
        }
    }
}

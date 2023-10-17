using HabitBuilder2.ViewModels.DataModels.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components
{
    public class HabitBarViewModel : INotifyPropertyChanged
    {
        private HabitViewModel _habitViewModel;
        public ICommand BarSelectedCommand { get; set; }
        public HabitBarViewModel(HabitViewModel habitViewModel)
        {
            _habitViewModel = habitViewModel;
            BarSelectedCommand = new Command(() => _habitViewModel.SetSelected());
        }

        public string DisplayLevel => $"Lvl.{_habitViewModel.Level}";
        public string DisplayExperience => $"{_habitViewModel.ExperiencePoints}/21";
        // Add properties, methods, and commands specific to the HabitBar view
        // ...

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

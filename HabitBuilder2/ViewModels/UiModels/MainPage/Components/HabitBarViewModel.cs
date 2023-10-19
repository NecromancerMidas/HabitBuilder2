using HabitBuilder2.ViewModels.DataModels.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components
{
    public class HabitBarViewModel : BaseViewModel
    {
        public HabitViewModel Habit { get; set; }
        public ICommand BarSelectedCommand { get; set; }
        public HabitBarViewModel(HabitViewModel habitViewModel)
        {
            Habit = habitViewModel;
            Debug.WriteLine(Habit.Title);
            BarSelectedCommand = new Command(() => Habit.SetSelected());
        }

        public string DisplayLevel => $"Lvl.{Habit.Level}";
        public string DisplayExperience => $"{Habit.ExperiencePoints}/21";
        // Add properties, methods, and commands specific to the HabitBar view
        // ...
    }
}

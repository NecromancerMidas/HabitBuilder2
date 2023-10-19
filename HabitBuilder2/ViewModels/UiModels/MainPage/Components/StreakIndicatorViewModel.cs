using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components;

public class StreakIndicatorViewModel : BaseViewModel
{
    
    public HabitViewModel Habit { get; set; }

    public StreakIndicatorViewModel(HabitViewModel habit)
    {
        Habit = habit;
    }
    //public Color Color => Habit.Status != HabitStatus.Frozen ? Color.FromArgb("#00000") : Color.FromArgb("#0000");

  
}
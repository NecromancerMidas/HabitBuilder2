using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services.Factories;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components;

public class HabitOverviewHabitViewModel : BaseViewModel
{
    private readonly IViewModelFactory _viewModelFactory;
    public HabitViewModel Habit { get; set; }
    public HabitBarViewModel HabitBar { get; set; }
    public StreakIndicatorViewModel StreakIndicator { get; set; }
    public HabitOverviewHabitViewModel(Habit habit, IViewModelFactory viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
        Habit = new HabitViewModel(habit,null);
        HabitBar = _viewModelFactory.CreateViewModel<HabitBarViewModel>(Habit);
        StreakIndicator = new StreakIndicatorViewModel(Habit);
    }
}
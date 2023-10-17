using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.ViewModels.DataModels.Templates;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components;

public class HabitOverviewHabitViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public HabitViewModel Habit { get; set; }
    public HabitBarViewModel HabitBar { get; set; }
    public StreakIndicatorViewModel StreakIndicator { get; set; }
    
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
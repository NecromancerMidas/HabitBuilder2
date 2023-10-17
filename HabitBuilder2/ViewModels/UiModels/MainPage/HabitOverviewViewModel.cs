using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.UiModels.MainPage.Components;

namespace HabitBuilder2.ViewModels.UiModels.MainPage;

public class HabitOverviewViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;


    public HabitViewModel Habit { get; set; }
    public HabitOverviewHabitViewModel HabitOverviewHabitViewModel { get; set; }


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
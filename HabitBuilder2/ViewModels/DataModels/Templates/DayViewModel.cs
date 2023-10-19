using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.DataModels.Templates;

public class DayViewModel : BaseViewModel
{
    private DateTime _date;
    private DayOfWeek _dayOfWeek;
    private bool _active;
    private bool _completed;
    private string _description;
    private bool _reminder;
    private TimeSpan _time;
    private LogViewModel _log;
    public DayViewModel(Day day)
    {
        _date = day.Date;
        _dayOfWeek = day.DayOfWeek;
        _active = day.Active;
        _completed = day.Completed;
        _description =day.Description;
        _reminder = day.Reminder;
        _time = day.Time;
        _log = new LogViewModel(day.Log);
    }
    public DateTime Date
    {
        get => _date;
        set => SetField(ref _date, value);
    }

    public DayOfWeek DayOfWeek
    {
        get => _dayOfWeek;
        set => SetField(ref _dayOfWeek, value);
    }

    public bool Active
    {
        get => _active;
        set => SetField(ref _active, value);
    }

    public bool Completed
    {
        get => _completed;
        set
        => SetField(ref _completed, value);
    }

    public string Description
    {
        get => _description;
        set => SetField(ref _description, value);
    }

    public bool Reminder
    {
        get => _reminder;
        set => SetField(ref _reminder, value);
    }

    public TimeSpan Time
    {
        get => _time;
        set => SetField(ref _time, value);
    }

    public LogViewModel Log
    {
        get => _log;
        set => SetField(ref _log, value);

    }

   


    
}
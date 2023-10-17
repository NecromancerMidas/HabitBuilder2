using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.ViewModels.DataModels.Templates;

public class DayViewModel : INotifyPropertyChanged
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
        set
        {
            if (value.Equals(_date)) return;
            _date = value;
            OnPropertyChanged();
        }
    }

    public DayOfWeek DayOfWeek
    {
        get => _dayOfWeek;
        set
        {
            if (value == _dayOfWeek) return;
            _dayOfWeek = value;
            OnPropertyChanged();
        }
    }

    public bool Active
    {
        get => _active;
        set
        {
            if (value == _active) return;
            _active = value;
            OnPropertyChanged();
        }
    }

    public bool Completed
    {
        get => _completed;
        set
        {
            if (value == _completed) return;
            _completed = value;
            OnPropertyChanged();
        }
    }

    public string Description
    {
        get => _description;
        set
        {
            if (value == _description) return;
            _description = value;
            OnPropertyChanged();
        }
    }

    public bool Reminder
    {
        get => _reminder;
        set
        {
            if (value == _reminder) return;
            _reminder = value;
            OnPropertyChanged();
        }
    }

    public TimeSpan Time
    {
        get => _time;
        set
        {
            if (value.Equals(_time)) return;
            _time = value;
            OnPropertyChanged();
        }
    }

    public LogViewModel Log
    {
        get => _log;
        set
        {
            if (Equals(value, _log)) return;
            _log = value;
            OnPropertyChanged();
        }
    }

   


    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    
}
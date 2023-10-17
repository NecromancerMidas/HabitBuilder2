using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.ViewModels.DataModels.Templates;

public class LogViewModel : INotifyPropertyChanged
{
    private string _stateOfMind;
    private string _accomplish;
    private string _challenges;
    private string _thoughts;
    private DateTime? _entryDate;

    public LogViewModel(Log dayLog)
    {
        if (dayLog != null)
        {
            _stateOfMind = dayLog.StateOfMind;
            _accomplish = dayLog.Accomplish;
            _challenges = dayLog.Challenges;
            _thoughts = dayLog.Thoughts;
            _entryDate = dayLog.EntryDate;
        }
    }

    public string StateOfMind
    {
        get => _stateOfMind;
        set
        {
            if (value == _stateOfMind) return;
            _stateOfMind = value;
            OnPropertyChanged();
        }
    }

    public string Accomplish
    {
        get => _accomplish;
        set
        {
            if (value == _accomplish) return;
            _accomplish = value;
            OnPropertyChanged();
        }
    }

    public string Challenges
    {
        get => _challenges;
        set
        {
            if (value == _challenges) return;
            _challenges = value;
            OnPropertyChanged();
        }
    }

    public string Thoughts
    {
        get => _thoughts;
        set
        {
            if (value == _thoughts) return;
            _thoughts = value;
            OnPropertyChanged();
        }
    }

    public DateTime? EntryDate
    {
        get => _entryDate;
        set
        {
            if (value.Equals(_entryDate)) return;
            _entryDate = value;
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
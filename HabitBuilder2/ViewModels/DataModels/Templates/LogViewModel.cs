using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.DataModels.Templates;

public class LogViewModel : BaseViewModel
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
        set => SetField(ref _stateOfMind, value);
    }

    public string Accomplish
    {
        get => _accomplish;
        set => SetField(ref _accomplish, value);
    }

    public string Challenges
    {
        get => _challenges;
        set => SetField(ref _challenges, value);
    }

    public string Thoughts
    {
        get => _thoughts;
        set => SetField(ref _thoughts, value);
    }

    public DateTime? EntryDate
    {
        get => _entryDate;
        set => SetField(ref _entryDate, value);
    }
}
namespace HabitBuilder2.Services.EventAggregatorArgs;

public class LifeCycleArgs
{
    public string Origin { get; set; }

    public LifeCycleArgs(string origin)
    {
        Origin = origin;
    }
}
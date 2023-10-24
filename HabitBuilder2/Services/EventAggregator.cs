using HabitBuilder2.Services.EventAggregatorArgs;

namespace HabitBuilder2.Services;

public class EventAggregator
{

    public event Action<SelectionEventArgs> SelectedItem;
    public void SelectItem(string origin,object item)
    {
        SelectionEventArgs args = new SelectionEventArgs(origin, item);
        
        SelectedItem?.Invoke(args);
    }
}
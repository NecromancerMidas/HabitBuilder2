using HabitBuilder2.Services.EventAggregatorArgs;

namespace HabitBuilder2.Services;

public class EventAggregator
{

    public event EventHandler<SelectionEventArgs> SelectedItem;
    public event EventHandler<LifeCycleArgs> LifeCycleEvent;
    public void SelectItem(string origin,object item)
    {
        SelectionEventArgs args = new SelectionEventArgs(origin, item);
        
        SelectedItem?.Invoke(this,args);
    }

    public void InvokeLifeCycleEvent(string origin)
    {
       var args = new LifeCycleArgs(origin);
        LifeCycleEvent?.Invoke(this,args);
    }
}
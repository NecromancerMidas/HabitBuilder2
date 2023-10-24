using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.UiModels.MainPage.Components;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.Services.Factories;

public class ViewModelFactory : IViewModelFactory
{
    
        private readonly EventAggregator _eventAggregator;

        public ViewModelFactory(EventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public T CreateViewModel<T>() where T : BaseViewModel
        {
            throw new NotImplementedException();
        }

        

        public T CreateViewModel<T>(HabitViewModel habit)
            where T : BaseViewModel
            
        {
            if (typeof(T) == typeof(HabitBarViewModel))
            {
                return (T)(object)new HabitBarViewModel(habit, _eventAggregator);
            }

            // Add more view models as needed

            throw new InvalidOperationException("ViewModel not recognized");
        }

}

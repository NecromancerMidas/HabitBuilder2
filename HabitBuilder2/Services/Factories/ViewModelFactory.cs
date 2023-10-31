using System.Runtime.CompilerServices;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.UiModels.MainPage;
using HabitBuilder2.ViewModels.UiModels.MainPage.Components;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.Services.Factories;

public class ViewModelFactory : IViewModelFactory
{
    
        private readonly EventAggregator _eventAggregator;
        private readonly IDataServiceFactory _dataServiceFactory;
        private readonly IViewModelFactory _viewModelFactory;

        public ViewModelFactory(EventAggregator eventAggregator, IDataServiceFactory dataServiceFactory)
        {
            _eventAggregator = eventAggregator;
            _dataServiceFactory = dataServiceFactory;
            _viewModelFactory = this;
        }

        public T CreateViewModel<T>() where T : BaseViewModel
        {
            /*if (typeof(T) == typeof(DetailedViewViewModel))
            {
                return (T)(object) new DetailedViewViewModel();
            }*/

            /*if (typeof(T) == typeof(DetailedTemplateOverviewViewModel))
            {
                return (T)(object) new DetailedTemplateOverviewViewModel();
            }*/

            throw new InvalidOperationException("Viewmodel is wrong or something Factory");
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

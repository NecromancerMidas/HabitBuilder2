using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.Services.Factories;

public interface IViewModelFactory
{
    T CreateViewModel<T>() where T : BaseViewModel;

    T CreateViewModel<T>(HabitViewModel viewModel)
        where T : BaseViewModel;
}
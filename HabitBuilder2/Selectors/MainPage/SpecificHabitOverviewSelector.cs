using HabitBuilder2.ViewModels.DataModels.Templates;

namespace HabitBuilder2.Selectors.MainPage;

public class SpecificHabitOverviewSelector : DataTemplateSelector
{
    public DataTemplate SpecificHabitOverViewDetails { get; set; }
    public DataTemplate SomethingElse { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (item is HabitViewModel viewModel)
        {
            return viewModel.CurrentView switch
            {
                HabitViewModel.ViewType.SpecificHabitOverviewDetails => SpecificHabitOverViewDetails,
                HabitViewModel.ViewType.SomethingElse => SomethingElse,
                _ => throw new InvalidOperationException("Unknown display mode")
            };
        }
        throw new InvalidOperationException("Unknown item type");
    }
}
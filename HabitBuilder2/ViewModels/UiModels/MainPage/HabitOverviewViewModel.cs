using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services.Factories;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.UiModels.MainPage.Components;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage;

public class HabitOverviewViewModel : BaseViewModel
{

    public object SelectedItem { get; set; }

    public TemplateViewModel Template { get; set; }
    public ObservableCollection<HabitOverviewHabitViewModel> HabitList { get; set; }

    public HabitOverviewViewModel(Template template, IViewModelFactory viewModelFactory)
    {
        Template = new TemplateViewModel(template);
        HabitList = new ObservableCollection<HabitOverviewHabitViewModel>(template.HabitList.Select(h => new HabitOverviewHabitViewModel(h, viewModelFactory)));
        
    }

    
}

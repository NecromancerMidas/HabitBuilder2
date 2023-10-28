using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using HabitBuilder2.Models;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services.DataService;
using HabitBuilder2.Services.Factories;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<HabitOverviewViewModel> _templates;
        private readonly IViewModelFactory _viewModelFactory;
        private TemplateViewModel _selectedTemplate;
        public ICommand ItemChangedCommand { get; }

        public MainPageViewModel(IGenericDataService<Template> dataService, IViewModelFactory viewModelFactory)
        {
            ItemChangedCommand = new Command<TemplateViewModel>(OnItemChanged);
            _viewModelFactory = viewModelFactory;
            Templates =
                new ObservableCollection<HabitOverviewViewModel>(dataService.GetAll().Select(t => new HabitOverviewViewModel(t,_viewModelFactory)));
            
        }

        private void OnItemChanged(TemplateViewModel newItem)
        {
            // Do something with the new item
            Console.WriteLine($"Selected item: {newItem}");
            SelectedTemplate = newItem;
        }

        public ObservableCollection<HabitOverviewViewModel> Templates
        {
            get => _templates;
            set => SetField(ref _templates, value);
        }

        public TemplateViewModel SelectedTemplate
        {
            get => _selectedTemplate;
            set => SetField(ref _selectedTemplate, value);
        }
    }

}

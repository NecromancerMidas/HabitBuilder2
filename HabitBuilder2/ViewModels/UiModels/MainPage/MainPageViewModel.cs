using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using HabitBuilder2.Models;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
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
        private DetailedViewViewModel _childDetailedViewViewModel;
        private EventAggregator _eventAggregator;
        public ICommand ItemChangedCommand { get; }

        public MainPageViewModel(IGenericDataService<Template> dataService, IViewModelFactory viewModelFactory,EventAggregator aggregator)
        {
            _viewModelFactory = viewModelFactory;
            Templates =
                new ObservableCollection<HabitOverviewViewModel>(dataService.GetAll().Select(t => new HabitOverviewViewModel(t, _viewModelFactory)));
            ItemChangedCommand = new Command<HabitOverviewViewModel>(OnItemChanged);

            ChildDetailedViewViewModel = new DetailedViewViewModel(Templates[0].Template);
            _eventAggregator = aggregator;
        }
        public DetailedViewViewModel ChildDetailedViewViewModel
        {
            get => _childDetailedViewViewModel;
            set => SetField(ref _childDetailedViewViewModel, value);
        }
        private void OnItemChanged(HabitOverviewViewModel newItem)
        {if(newItem == null) return;
            // Do something with the new item
           Debug.WriteLine($"Selected item: {newItem}");
           Debug.WriteLine($"Selected item: {newItem.Template}");
            SelectedTemplate = newItem.Template;
            ChildDetailedViewViewModel.OnItemChanged(newItem.Template);
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

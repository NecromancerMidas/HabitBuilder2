using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using HabitBuilder2.Models;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<HabitOverviewViewModel> _templates;


        private TemplateViewModel _selectedTemplate;
        public ICommand ItemChangedCommand { get; }

        public MainPageViewModel(MainPageModel mainpage)
        {
            ItemChangedCommand = new Command<TemplateViewModel>(OnItemChanged);
            Templates =
                new ObservableCollection<HabitOverviewViewModel>(mainpage.Templates.Select(t => new HabitOverviewViewModel(t)));

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

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using HabitBuilder2.Selectors.MainPage;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage
{
    public class DetailedViewViewModel : BaseViewModel
    {
        private object _selectedItem;
        private View _dynamicContent;
        private bool _showDetailedTemplateView;
        private bool _showSpecificHabitOverview;
        public View DynamicContent
        {
            get => _dynamicContent;
            set
            => SetField(ref _dynamicContent, value);
        }
        public DetailedViewTemplateSelector TemplateSelector { get; set; }
        public ICommand ItemChangedCommand { get; set; }
        public DetailedViewViewModel()
        {
            ItemChangedCommand = new Command<TemplateViewModel>(OnItemChanged);
        }
        public object SelectedItem
        {
            get=> _selectedItem;
            set => SetField(ref _selectedItem, value);
        }
        private void OnItemChanged(TemplateViewModel newItem)
        {
            // Do something with the new item
            Console.WriteLine($"Selected item: {newItem}");
            SelectedItem = newItem;
            _showDetailedTemplateView = true;
            _showSpecificHabitOverview = false;
            
        }
        public void SetSelectedItem(HabitViewModel item)
        {
            if (_selectedItem is TemplateViewModel)
            {
                _showDetailedTemplateView = true;
                _showSpecificHabitOverview = false;
            }

            if (_selectedItem is HabitViewModel)
            {
                _showSpecificHabitOverview = true;
                _showDetailedTemplateView = false;
            }

        }
        
        public bool ShowDetailedTemplateView
        {
            get => _showDetailedTemplateView;
            set => SetField(ref _showDetailedTemplateView, value);
        }

       
        public bool ShowSpecificHabitOverview
        {
            get => _showSpecificHabitOverview;
            set => SetField(ref _showSpecificHabitOverview, value);
        }





        /*public DetailedViewViewModel()
        {
            // Logic to decide which view to show
            if ()
            {
                ShowDetailedTemplateView = true;
                ShowSpecificHabitOverview = false;
            }
            else
            {
                ShowDetailedTemplateView = false;
                ShowSpecificHabitOverview = true;
            }
            // Initialize TemplateSelector
            TemplateSelector = new DetailedViewTemplateSelector();

            // Use TemplateSelector to decide which template to use
            var template = TemplateSelector.SelectTemplate(this, null);
            if (template != null)
            {
                DynamicContent = (View)template.CreateContent();
                DynamicContent.BindingContext = this;
            }
        }*/

        
    }
}

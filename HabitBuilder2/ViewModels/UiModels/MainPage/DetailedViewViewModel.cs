using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Selectors.MainPage;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage
{
    internal class DetailedViewViewModel : BaseViewModel
    {
        private View _dynamicContent;
        public View DynamicContent
        {
            get => _dynamicContent;
            set
            => SetField(ref _dynamicContent, value);
        }
        public DetailedViewTemplateSelector TemplateSelector { get; set; }


        private bool _showDetailedTemplateView;
        public bool ShowDetailedTemplateView
        {
            get => _showDetailedTemplateView;
            set => SetField(ref _showDetailedTemplateView, value);
        }

        private bool _showSpecificHabitOverview;
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

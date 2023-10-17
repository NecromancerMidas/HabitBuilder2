using System.ComponentModel;
using System.Runtime.CompilerServices;
using HabitBuilder2.Selectors.MainPage;

namespace HabitBuilder2.ViewModels.UiModels.MainPage
{
    internal class DetailedViewViewModel : INotifyPropertyChanged
    {
        private View _dynamicContent;
        public View DynamicContent
        {
            get => _dynamicContent;
            set
            {
                _dynamicContent = value;
                OnPropertyChanged(nameof(DynamicContent));
            }
        }
        public DetailedViewTemplateSelector TemplateSelector { get; set; }


        private bool _showDetailedTemplateView;
        public bool ShowDetailedTemplateView
        {
            get => _showDetailedTemplateView;
            set
            {
                _showDetailedTemplateView = value;
                OnPropertyChanged(nameof(ShowDetailedTemplateView));
            }
        }

        private bool _showSpecificHabitOverview;
        public bool ShowSpecificHabitOverview
        {
            get => _showSpecificHabitOverview;
            set
            {
                _showSpecificHabitOverview = value;
                OnPropertyChanged(nameof(ShowSpecificHabitOverview));
            }
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}

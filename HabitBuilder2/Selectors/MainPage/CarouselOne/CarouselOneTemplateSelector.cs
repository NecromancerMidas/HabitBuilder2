using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.ViewModels.Templates;


namespace HabitBuilder2.Selectors.MainPage.CarouselOne
{
   public class CarouselOneTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DetailedTemplateView { get; set; }
        public DataTemplate GraphsOrSomething { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is TemplateViewModel viewModel)
            {
                return viewModel.CurrentView switch
                {
                    TemplateViewModel.ViewType.DetailedTemplateView => DetailedTemplateView,
                    TemplateViewModel.ViewType.GraphsOrSomething => GraphsOrSomething,
                    _ => throw new InvalidOperationException("Unknown display mode")
                };
            }
            throw new InvalidOperationException("Unknown item type");
        }
    }
}

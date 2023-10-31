using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.UiModels.MainPage.Components;


namespace HabitBuilder2.Selectors.MainPage.CarouselOne
{
   public class CarouselOneTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DetailedTemplateOverviewView { get; set; }
        public DataTemplate GraphsOrSomething { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is DetailedTemplateOverviewViewModel)
            {
                return DetailedTemplateOverviewView;
            }
            if (item is DetailedTemplateGraphsViewModel)
            {
                return GraphsOrSomething;
            }
            throw new InvalidOperationException("Unknown item type");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.UiModels.MainPage.Components;

namespace HabitBuilder2.Selectors.MainPage
{
    public class DetailedViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DetailedTemplateView { get; set; }
        public DataTemplate SpecificHabitOverview { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is DetailedTemplateViewModel)
            {
                return DetailedTemplateView;
            }
            else if (item is HabitViewModel)
            {
                return SpecificHabitOverview;
            }
            return null;
        }
    }
}

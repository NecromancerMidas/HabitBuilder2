using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.ViewModels.Templates;

namespace HabitBuilder2.Selectors.MainPage
{
    internal class DetailedViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DetailedTemplateView { get; set; }
        public DataTemplate SpecificHabitOverview { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is TemplateViewModel)
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

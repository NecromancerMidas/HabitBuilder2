using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components
{
    public class DetailedTemplateViewCarousel : BaseViewModel
    {
        private TemplateViewModel _template;

        public DetailedTemplateViewCarousel(TemplateViewModel template)
        {
            Template = template;
        }

        public TemplateViewModel Template
        {
            get => _template;
            set => SetField(ref _template, value);
        }
        public void SetTemplate(TemplateViewModel template)
        {
            Template = template;
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.Selectors.MainPage.CarouselOne
{
   public class CarouselOneTemplateSelector : DataTemplateSelector
    {
        public DataTemplate HabitOverviewTemplate { get; set; }
        public DataTemplate OtherHabitOverviewTemplate { get; set; }


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (item)
            {
                default:
                    return null;
            }
        }
    }
}

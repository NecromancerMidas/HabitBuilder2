﻿using HabitBuilder2.ViewModels.ViewModelBase;
using System.Collections.ObjectModel;

using HabitBuilder2.ViewModels.DataModels.Templates;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components;

public class DetailedTemplateOverviewViewModel : BaseViewModel , IDetailedTemplateCarousel
{

    public string Title { get; set; }= "Yo";
    
    private TemplateViewModel _template;

    public DetailedTemplateOverviewViewModel(TemplateViewModel template)
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

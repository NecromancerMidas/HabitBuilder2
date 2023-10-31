using Android.App.AppSearch;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components;

public class DetailedTemplateGraphsViewModel : BaseViewModel, IDetailedTemplateCarousel
{
    public string Title { get; set; }= "Yo";

    private TemplateViewModel _template;

    public DetailedTemplateGraphsViewModel(TemplateViewModel template)
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
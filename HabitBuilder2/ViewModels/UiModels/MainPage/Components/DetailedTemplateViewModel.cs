using HabitBuilder2.ViewModels.ViewModelBase;
using System.Collections.ObjectModel;
using System.Diagnostics;
using HabitBuilder2.ViewModels.DataModels.Templates;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components;

public class DetailedTemplateViewModel : BaseViewModel
{
    /*public enum ViewType
    {
        DetailedTemplateView,
        TemplateEditView,
        GraphsOrSomething
    }*/
    private TemplateViewModel _template;
    private ObservableCollection<IDetailedTemplateCarousel> _carousel;
    public DetailedTemplateOverviewViewModel Test { get; set; }
    public string String { get; set; } = "Gobgogabgalab";

    public DetailedTemplateViewModel(TemplateViewModel template)
    {
        _template = template;
        Carousel = new ObservableCollection<IDetailedTemplateCarousel>()
        {
            new DetailedTemplateOverviewViewModel(template),
            new DetailedTemplateGraphsViewModel(template),
        };
        Test = new DetailedTemplateOverviewViewModel(template);

    }

    public void UpdateCarousel(TemplateViewModel template)
    {
        Debug.WriteLine("Setting Carousel Templates");
        _carousel[0].SetTemplate(template);
        _carousel[1].SetTemplate(template);
        OnPropertyChanged(nameof(Carousel));
    }

    public ObservableCollection<IDetailedTemplateCarousel> Carousel
    {
        get => _carousel;
        set => SetField(ref _carousel, value);
    }

}

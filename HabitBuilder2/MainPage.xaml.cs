using HabitBuilder2.TempDB;
using HabitBuilder2.ViewModels.Templates;

namespace HabitBuilder2;
public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        var templates = TempDb.Templates.Select(t => new TemplateViewModel(t)).ToList();
    }
}


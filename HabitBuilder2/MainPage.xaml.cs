using HabitBuilder2.Models;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.TempDB;
using HabitBuilder2.ViewModels;
using HabitBuilder2.ViewModels.Templates;

namespace HabitBuilder2;
public partial class MainPage : ContentPage
{
    public MainPageViewModel ViewModel;
    public MainPage()
	{
		InitializeComponent();
        var templates = TempDb.Templates.Select(t => new TemplateViewModel(t)).ToList();
        ViewModel = new MainPageViewModel()
        {
            

        }
         
    }
}


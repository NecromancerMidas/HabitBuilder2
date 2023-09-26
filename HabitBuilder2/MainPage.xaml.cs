using HabitBuilder2.Models;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
using HabitBuilder2.TempDB;
using HabitBuilder2.ViewModels;
using HabitBuilder2.ViewModels.Templates;
using System.Collections.ObjectModel;

namespace HabitBuilder2;
public partial class MainPage : ContentPage
{
    public MainPageViewModel ViewModel;
    public MainPage()
	{
		InitializeComponent();
        
        

        // Initialize model and ViewModel
        IDataService dataService = new TempDbDataService();
        MainPageModel mainPageModel = new MainPageModel(dataService);
        ViewModel = new MainPageViewModel(mainPageModel);

        // Set the BindingContext
        BindingContext = ViewModel;

    }
}


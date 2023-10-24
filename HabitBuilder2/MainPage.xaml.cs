using HabitBuilder2.Models;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
using HabitBuilder2.TempDB;
using HabitBuilder2.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using HabitBuilder2.Services.Factories;
using HabitBuilder2.ViewModels.DataModels.Templates;
using HabitBuilder2.ViewModels.UiModels.MainPage;

namespace HabitBuilder2;
public partial class MainPage : ContentPage
{
    public MainPageViewModel ViewModel;
    public TemplateViewModel ChildViewModel;
    public TemplateViewModel CarouselOneCurrentItem;
    public MainPage(IDataService dataService, IViewModelFactory viewModelFactory)
	{



        
        





        Debug.WriteLine(BindingContext);
        // Initialize model and ViewModel
       /* IDataService dataService = new TempDbDataService();
        MainPageModel mainPageModel = new MainPageModel(dataService);
        ViewModel = new MainPageViewModel(mainPageModel);*/
      
        // Set the BindingContext
        BindingContext = new MainPageViewModel(dataService,viewModelFactory);
        
        Debug.WriteLine(BindingContext);
        Debug.WriteLine(BindingContext);
        Debug.WriteLine($"{BindingContext.GetType().GetProperties().GetValue(0)}");
        InitializeComponent();
    }
}


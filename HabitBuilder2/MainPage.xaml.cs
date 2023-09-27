using HabitBuilder2.Models;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
using HabitBuilder2.TempDB;
using HabitBuilder2.ViewModels;
using HabitBuilder2.ViewModels.Templates;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

namespace HabitBuilder2;
public partial class MainPage : ContentPage
{
    public MainPageViewModel ViewModel;
    public TemplateViewModel ChildViewModel;
    public MainPage()
	{
        


        Debug.WriteLine(BindingContext);
        // Initialize model and ViewModel
        IDataService dataService = new TempDbDataService();
        MainPageModel mainPageModel = new MainPageModel(dataService);
        ViewModel = new MainPageViewModel(mainPageModel);
      
        // Set the BindingContext
        BindingContext = ViewModel;
        
        Debug.WriteLine(BindingContext);
        Debug.WriteLine(BindingContext);
        Debug.WriteLine(ViewModel.Templates[0]);
        Debug.WriteLine(ViewModel.Templates[0].HabitList[0]);
        Debug.WriteLine(ViewModel.Templates[0].HabitList[0].Description);
        Debug.WriteLine($"{BindingContext.GetType().GetProperties().GetValue(0)}");
        InitializeComponent();
    }
}


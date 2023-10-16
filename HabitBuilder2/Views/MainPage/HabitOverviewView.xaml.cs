using System.Diagnostics;
using HabitBuilder2.Models;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
using HabitBuilder2.TempDB;
using HabitBuilder2.ViewModels;
using HabitBuilder2.ViewModels.DataModels.Templates;

namespace HabitBuilder2.Views.MainPage;


public partial class HabitOverviewView : ContentView
{
    public TemplateViewModel ViewModel;
    public HabitOverviewView()
    {

        Debug.WriteLine(BindingContext);
        InitializeComponent();
        Debug.WriteLine(BindingContext);
        
	}
    
}
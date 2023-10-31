using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.Views.MainPage;

public partial class DetailedView : ContentView
{
    public DetailedView()
    {
        InitializeComponent();
        Debug.WriteLine($"This is {BindingContext}");
        if (BindingContext != null)
        {
            Debug.WriteLine(BindingContext.GetType().Name);
        }
        
    }
}
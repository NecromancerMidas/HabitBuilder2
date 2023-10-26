using System.Globalization;
using Microsoft.Maui.Controls.Shapes;
using HabitBuilder2.Utilities.HabitBar.Converter;
using System.ComponentModel;
using System.Diagnostics;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.ViewModels.DataModels.Templates;
using Microsoft.Maui.Controls;

namespace HabitBuilder2.Views.MainPage.Components.MainPageHabitOverviewComponents;

public partial class HabitBarView : ContentView
{
    /*public static readonly BindableProperty HabitTitleProp = BindableProperty.Create(
        nameof(HabitTitle), typeof(string), typeof(HabitBarView), default(string));
    public static readonly BindableProperty HabitLevelProp = BindableProperty.Create(
        nameof(HabitLevel), typeof(int), typeof(HabitBarView), default(int));
    public static readonly BindableProperty HabitStreakProp = BindableProperty.Create(
        nameof(HabitStreak), typeof(int), typeof(HabitBarView), default(int));
*/


    // private int _habitStreak = 5;
    private readonly HabitBarWidthConverter _converter = new();

    public HabitBarView()
    {
        InitializeComponent();
        Debug.WriteLine(BindingContext);

    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        UpdateLoadingBarWidth();
        
    }
    
    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();

        if (BindingContext is INotifyPropertyChanged notifyPropertyChanged)
        {
            notifyPropertyChanged.PropertyChanged += ViewModel_PropertyChanged;
        }
    }

    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "ExperiencePoints")
        {
            UpdateLoadingBarWidth();
        }
    }

    /* private void BarSelected(object sender, EventArgs e)
     {
         Debug.WriteLine("Tapped");
         if (BindingContext is HabitViewModel viewModel)
         {
             viewModel.Status = HabitStatus.Selected;
         }
          
     }*/
    


    /*public string HabitTitle
    {
        get => (string)GetValue(HabitTitleProp);
        set => SetValue(HabitTitleProp,value);
    }

    public int HabitLevel
    {
        get => (int)GetValue(HabitLevelProp);
        set => SetValue(HabitLevelProp, value);
    }*/
    /* public int HabitStreak
     {
         get => (int)GetValue(HabitStreakProp);
         set
         {
             SetValue(HabitStreakProp, value);
             UpdateLoadingBarWidth();
             System.Diagnostics.Debug.WriteLine("HabitStreak set: " + value);
         }
     }*/
    /*  public void AnimateWidth(RoundRectangle loadingBar, double startWidth, double endWidth, uint duration)
      {
          loadingBar.Animate("WidthAnimation", d => loadingBar.WidthRequest = d, startWidth, endWidth, length: duration);
      }
  */
    public void UpdateLoadingBarWidth()
    {
        if (BindingContext is HabitViewModel viewModel)
        {

            var converterValue = _converter.Convert(viewModel.ExperiencePoints, typeof(double), null, CultureInfo.CurrentCulture);
            if (converterValue is double value)
            {
                var width = (150 / 21) * value;
                LoadingRectangle.Animate("Progress",
                    d => LoadingRectangle.WidthRequest = d,
                    LoadingRectangle.WidthRequest,
                    width,
                    16,
                    6000,
                    Easing.Linear);

            }
        }
    }

}
using System.Globalization;
using Microsoft.Maui.Controls.Shapes;
using HabitBuilder2.Utilities.HabitBar.Converter;
using System.ComponentModel;
using HabitBuilder2.TempDB.Habits;

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

    
    private int _habitStreak = 5;
    private readonly HabitBarWidthConverter _converter = new();

    public HabitBarView()
    {
        InitializeComponent();
        UpdateLoadingBarWidth();
    }
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
    public void AnimateWidth(RoundRectangle loadingBar, double startWidth, double endWidth, uint duration)
    {
        loadingBar.Animate("WidthAnimation", d => loadingBar.WidthRequest = d, startWidth, endWidth, length: duration);
    }

    public void UpdateLoadingBarWidth()
    {
       /*var parentStreak = Parent as HabitOverviewHabitView;
       if (parentStreak != null) _habitStreak = parentStreak.HabitStreak;*/
       var converterValue = _converter.Convert(_habitStreak, typeof(double), null, CultureInfo.CurrentCulture);
        if (converterValue is double value)
        {
           var width = (150 / 21) * value;
            LoadingRectangle.WidthRequest = width;
        }
    }

}
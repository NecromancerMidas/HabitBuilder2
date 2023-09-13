using System.Globalization;
using Microsoft.Maui.Controls.Shapes;
using HabitBuilder2.Utilities.HabitBar.Converter;
namespace HabitBuilder2.Views.MainPage.Components.MainPageHabitOverviewComponents;

public partial class HabitBarView : ContentView
{
    public static readonly BindableProperty HabitTitleProp = BindableProperty.Create(
        nameof(HabitTitle), typeof(string), typeof(HabitBarView), default(string));
    public static readonly BindableProperty HabitLevelProp = BindableProperty.Create(
        nameof(HabitLevel), typeof(string), typeof(HabitBarView), default(string));
    public static readonly BindableProperty HabitStreakProp = BindableProperty.Create(
        nameof(HabitStreak), typeof(string), typeof(HabitBarView), default(string));

    private readonly HabitBarWidthConverter _converter = new();
    public HabitBarView()
	{
    
    InitializeComponent();
    BindingContext = this;
    UpdateLoadingBarWidth();
    }

    public string HabitTitle
    {
        get => (string)GetValue(HabitTitleProp);
        set => SetValue(HabitTitleProp,value);
    }

    public string HabitLevel
    {
        get => (string)GetValue(HabitLevelProp);
        set => SetValue(HabitLevelProp, value);
    }
    public string HabitStreak
    {
        get => (string)GetValue(HabitStreakProp);
        set
        {
            SetValue(HabitStreakProp, value);
            UpdateLoadingBarWidth();
            System.Diagnostics.Debug.WriteLine("HabitStreak set: " + value);
        }
    }
    public void AnimateWidth(RoundRectangle loadingBar, double startWidth, double endWidth, uint duration)
    {
        loadingBar.Animate("WidthAnimation", d => loadingBar.WidthRequest = d, startWidth, endWidth, length: duration);
    }

    public void UpdateLoadingBarWidth()
    {
        var converterValue = _converter.Convert(HabitStreak, typeof(double), null, CultureInfo.CurrentCulture);
        if (converterValue is double value)
        {
           var width = (150 / 21) * value;
            LoadingRectangle.WidthRequest = width;
        }
    }

}
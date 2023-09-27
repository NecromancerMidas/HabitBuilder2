

using System.Diagnostics;
using HabitBuilder2.Models;
using HabitBuilder2.Services;
using HabitBuilder2.TempDB;
using HabitBuilder2.ViewModels;
using HabitBuilder2.ViewModels.Templates;

namespace HabitBuilder2.Views.MainPage.Components.MainPageHabitOverviewComponents;

public partial class HabitOverviewHabitView : ContentView
{
 /*   public bool DataReady;
    public static readonly BindableProperty HabitTitleProp = BindableProperty.Create(
        nameof(HabitTitle), typeof(string), typeof(HabitOverviewHabitView), default(string));
    public static readonly BindableProperty HabitLevelProp = BindableProperty.Create(
        nameof(HabitLevel), typeof(int), typeof(HabitOverviewHabitView), default(int));
    public static readonly BindableProperty HabitTotalProp = BindableProperty.Create(
        nameof(HabitTotal), typeof(int), typeof(HabitOverviewHabitView), default(int));
    public static readonly BindableProperty HabitStreakProp = BindableProperty.Create(
        nameof(HabitStreak), typeof(int), typeof(HabitOverviewHabitView), default(int));*/


    public HabitOverviewHabitView() {
        
        Debug.WriteLine(BindingContext);
        InitializeComponent();
        Debug.WriteLine(BindingContext);
    }

    public HabitViewModel ViewModel { get; set; }

    /*public string HabitTitle
    {
        get => (string)GetValue(HabitTitleProp);
        set => SetValue(HabitTitleProp, value);
    }

    public int HabitLevel
    {
        get => (int)GetValue(HabitLevelProp);
        set => SetValue(HabitLevelProp, value);
    }

    public int HabitTotal
    {
        get => (int)GetValue(HabitTotalProp);
        set => SetValue(HabitTotalProp, value);
    }

    public int HabitStreak
    {
        get => (int)GetValue(HabitStreakProp);
        set
        {
            SetValue(HabitStreakProp, value);
            System.Diagnostics.Debug.WriteLine($"HabitStreak in HabitOverviewHabitView set to: {HabitStreak}");
        }

    }*/
}
namespace HabitBuilder2.Views.MainPage.Components.MainPageHabitOverviewComponents;

public partial class HabitOverviewHabitView : ContentView
{

    public static readonly BindableProperty HabitTitleProp = BindableProperty.Create(
        nameof(HabitTitle), typeof(string), typeof(HabitOverviewHabitView), default(string));
    public static readonly BindableProperty HabitLevelProp = BindableProperty.Create(
        nameof(HabitLevel), typeof(int), typeof(HabitOverviewHabitView), default(int));
    public static readonly BindableProperty HabitTotalProp = BindableProperty.Create(
        nameof(HabitTotal), typeof(int), typeof(HabitOverviewHabitView), default(int));
    public static readonly BindableProperty HabitStreakProp = BindableProperty.Create(
        nameof(HabitStreak), typeof(int), typeof(HabitOverviewHabitView), default(int));


    public HabitOverviewHabitView()
	{
        BindingContext = this;
        InitializeComponent();
        
    }

    public string HabitTitle
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

    }
}
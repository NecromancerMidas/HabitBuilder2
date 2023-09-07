namespace HabitBuilder2.Views.MainPage.Components.MainPageHabitOverviewComponents;

public partial class HabitBar : ContentView
{
    public static readonly BindableProperty HabitTitleProp = BindableProperty.Create(
        nameof(HabitTitle), typeof(string), typeof(HabitBar), default(string));
    public HabitBar()
	{
    
    InitializeComponent();
    }

    public string HabitTitle
    {
        get => (string)GetValue(HabitTitleProp);
        set => SetValue(HabitTitleProp,value);
    }
}
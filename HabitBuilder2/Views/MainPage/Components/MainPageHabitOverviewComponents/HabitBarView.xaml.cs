namespace HabitBuilder2.Views.MainPage.Components.MainPageHabitOverviewComponents;

public partial class HabitBarView : ContentView
{
    public static readonly BindableProperty HabitTitleProp = BindableProperty.Create(
        nameof(HabitTitle), typeof(string), typeof(HabitBarView), default(string));
    public HabitBarView()
	{
    
    InitializeComponent();
    }

    public string HabitTitle
    {
        get => (string)GetValue(HabitTitleProp);
        set => SetValue(HabitTitleProp,value);
    }
}
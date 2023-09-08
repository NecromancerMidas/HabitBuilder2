using HabitBuilder2.ViewModels.MainPage.CarouselOne;

namespace HabitBuilder2;
using ViewModels.MainPage;
public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new CarouselOneViewModel();
    }
}


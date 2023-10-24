using Microsoft.Extensions.DependencyInjection;

namespace HabitBuilder2;

public partial class App : Application
{
	public App(IServiceProvider serviceProvider)
	{
		InitializeComponent();

        
        var appShell = serviceProvider.GetService<AppShell>();
        MainPage = appShell;
        // Initialize MainPage inside AppShell from serviceProvider
/*        appShell.InitializeMainPage(serviceProvider);*/
    }
}

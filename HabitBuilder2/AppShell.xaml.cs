using Microsoft.Extensions.DependencyInjection;

namespace HabitBuilder2;

public partial class AppShell : Shell
{
    public AppShell()
    {
		InitializeComponent();
        
    }

/*    public void InitializeMainPage(IServiceProvider serviceProvider)
    {
        var mainPageInstance = serviceProvider.GetService<MainPage>();

        var shellContent = new ShellContent
        {
            Content = mainPageInstance,
        };
        Home.Items.Add(shellContent);
        Bomb.Items.Add(shellContent);

    }*/
}

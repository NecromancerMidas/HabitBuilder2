
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Repositories;
using HabitBuilder2.Services;
using HabitBuilder2.Services.DataService;
using HabitBuilder2.Services.Factories;
using HabitBuilder2.TempDB;
using Microsoft.Extensions.Logging;

namespace HabitBuilder2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .Services
            .AddSingleton<EventAggregator>()
            .AddSingleton<IRepository<Template>,TemplateRepository>()
            .AddSingleton<IHabitDataService<Habit>, HabitDataService<Habit>>()
            .AddSingleton<IGenericDataService<Template>,GenericDataService<Template>>()
            .AddSingleton<IDataServiceFactory, DataServiceFactory>()
            .AddSingleton<IViewModelFactory, ViewModelFactory>()
            .AddSingleton<AppShell>()
            .AddSingleton<MainPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

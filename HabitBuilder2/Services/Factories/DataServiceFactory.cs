using HabitBuilder2.Models.Templates;
using HabitBuilder2.Repositories;
using HabitBuilder2.Services.DataService;
using HabitBuilder2.TempDB;

namespace HabitBuilder2.Services.Factories;

public class DataServiceFactory : IDataServiceFactory
{
    
    private readonly IRepository<Template>_templateRepository;
    private readonly IHabitDataService<Habit> _habitDataService;
    private readonly IGenericDataService<Template> _templateDataservice;
    public DataServiceFactory(IHabitDataService<Habit> HabitDataService, IGenericDataService<Template> templateDataService)
    {
        _habitDataService = HabitDataService;
        _templateDataservice = templateDataService;
    }

    public IDataService<T> CreateDataService<T>(string serviceType)
    {
        
            switch (serviceType)
            {
                case "Generic Template":
                    return (IDataService<T>)_templateDataservice;
            case "Generic Habit" :
                return (IDataService<T>)_habitDataService;
                // Use your generic service here
                default:
                    throw new ArgumentException("Invalid service type specified", nameof(serviceType));
            }
    }
}
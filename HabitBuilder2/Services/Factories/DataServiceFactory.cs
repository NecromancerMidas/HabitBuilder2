using HabitBuilder2.Models.Templates;
using HabitBuilder2.Repositories;
using HabitBuilder2.TempDB;

namespace HabitBuilder2.Services.Factories;

public class DataServiceFactory : IDataServiceFactory
{
    
    private readonly IRepository<Template>_templateRepository;

    public DataServiceFactory(/*IHabitRepository habitRepository,*/ IRepository<Template> templateRepository)
    {
       /* _habitRepository = habitRepository;*/
        _templateRepository = templateRepository;
    }

    public IDataService<T> CreateDataService<T>(string serviceType)
    {
        
            switch (serviceType)
            {
                case "WithHabits":
                    return new DataServiceWithHabits(_habitRepository, _templateRepository);
                case "WithoutHabits":
                    return new DataServiceWithoutHabits(_templateRepository);
                case "Generic Template":
                    return (IDataService<T>) new TempDbDataService<Template>(_templateRepository);
            case "Generic Habit" :
                return (IDataService<T>) new TempDbDataService<Habit>();
                // Use your generic service here
                default:
                    throw new ArgumentException("Invalid service type specified", nameof(serviceType));
            }
    }
}
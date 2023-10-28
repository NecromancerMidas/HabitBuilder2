namespace HabitBuilder2.Services.Factories;

public interface IDataServiceFactory
{
    IDataService<T> CreateDataService<T>(string serviceType);
}
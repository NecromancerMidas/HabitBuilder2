namespace HabitBuilder2.Services.DataService;

public interface IGenericDataService<T> : IDataService<T>
{
    List<T> GetAll();
        T GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
}
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Repositories;

namespace HabitBuilder2.Services.DataService;

public class GenericDataService<T> : IGenericDataService<T>
{
    private IRepository<Template> _templateRepository;
    private IRepository<T> _repository;
    public GenericDataService(IRepository<T> repository)
    {
        _repository = repository;
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
        return _repository.GetAll().ToList(); // Assuming TempDb.Templates is your mock database
    }

    public T GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
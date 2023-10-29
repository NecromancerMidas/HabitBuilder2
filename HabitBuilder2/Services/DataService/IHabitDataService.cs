using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.Services.DataService;

public interface IHabitDataService<T> : IDataService<T>
{
    List<Habit> GetAll(Guid templateId);
    Habit GetById(Guid habitId, Guid templateId);
    void Add(Habit entity,Guid templateId);
    void Update(Habit habit, Guid templateId);
    void Delete(Guid habitId,Guid templateId);


}
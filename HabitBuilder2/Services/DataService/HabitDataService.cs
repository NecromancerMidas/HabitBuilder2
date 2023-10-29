using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Repositories;
using HabitBuilder2.Services.Factories;

namespace HabitBuilder2.Services.DataService
{
    internal class HabitDataService<T> : IHabitDataService<T>
    {
        private IRepository<Template> _templateRepository;

        public HabitDataService(IRepository<Template> templateRepository)
        {
            _templateRepository = templateRepository;
        }
        public List<Habit> GetAll(Guid templateId)
        {
            return _templateRepository.GetById(templateId).HabitList;
        }

        public Habit GetById(Guid habitId, Guid templateId)
        {
            return _templateRepository.GetById(templateId).HabitList.Find(habit => habit.Guid == habitId);
        }

        public void Add(Habit entity, Guid templateId)
        {
            throw new NotImplementedException();
        }

        public void Update(Habit habit, Guid templateId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid habitId, Guid templateId)
        {
            throw new NotImplementedException();
        }
    }
}

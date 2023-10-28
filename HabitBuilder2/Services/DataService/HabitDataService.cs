using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Repositories;
using HabitBuilder2.Services;

namespace HabitBuilder2.Services.DataService
{
    internal class TempDbHabitDataService<T> : IDataService<T>
    {
        private IRepository<Template> _templateRepository;


        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Habit GetById(Guid id, Guid templateId)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

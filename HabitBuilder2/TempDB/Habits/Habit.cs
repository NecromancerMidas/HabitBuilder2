using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.TempDB.Habits
{
    class Habit
    {
        public Habit(List<Day> days)
        {
            Days = days;
        }
        public Guid Id { get; private set; }
        public List<Day> Days { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}

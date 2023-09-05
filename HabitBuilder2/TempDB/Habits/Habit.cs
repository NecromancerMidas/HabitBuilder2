using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.TempDB.Habits
{
    class Habit
    {
        public Habit(Guid id,Week week)
        {
            Id = id;
            Week = week;
        }
        public Guid Id { get; private set; }
        public Week Week { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}

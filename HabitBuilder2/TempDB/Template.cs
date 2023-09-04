using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.TempDB.Habits;

namespace HabitBuilder2.TempDB
{
    class Template
    {
        public Template(List<Habit> habitList)
        {
            HabitList = habitList;
        }
        public List<Habit> HabitList;
    }
}

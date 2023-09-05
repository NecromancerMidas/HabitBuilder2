using HabitBuilder2.TempDB.Habits;
using DayOfWeek = HabitBuilder2.TempDB.Habits.DayOfWeek;

namespace HabitBuilder2.TempDB
{
    class TempDb
    {
        public TempDb()
        {
            Habits = new List<Habit>
            {
                new (
                    new Guid(),new Week(
                        "Paching",
                        new List<Day>
                        {
                            new Day(true, "Paching2", ":)", new TimeOnly(7, 2, 3), true)
                        }
                    )
                )
            };
        }
        
        public List<Habit> Habits { get; private set; }


    }
}

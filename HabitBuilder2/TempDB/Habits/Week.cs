using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.TempDB.Habits
{
    class Week
    {
        public Week(string overallDescription, List<Day> days)
        {
            OverallDescription = overallDescription;
            Days = days;
        }
        public string OverallDescription { get; private set; }
        public List<Day> Days { get; private set; }


    }
}

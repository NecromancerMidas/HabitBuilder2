using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.Models.Templates
{
    public class Week
    {

        public List<Day> Days { get; set; } = new();

        public Week(/*DateTime startDate*/)
        {

            for (int i = 0; i < 7; i++)
            {
                var startDate = DateTime.Now;
                Days.Add(new Day { Date = startDate.AddDays(i) });
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.Models.Templates.Habit
{
    public class Day
    {
        public DateTime Date { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public bool Active { get; set; }
        public bool Completed { get; set; }
        public string Description { get; set; }
        public bool Reminder { get; set; }
        public TimeSpan Time { get; set; }
        public Log Log { get; set; }


       
        // Any other properties that you wish to represent for a day
    }
}

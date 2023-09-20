using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.Models.Templates.Habit
{
    public class Log
    {
        public string StateOfMind { get; set; }
        public string Accomplish { get; set; }
        public string Challenges { get; set; }
        public string Thoughts { get; set; }
        public DateTime EntryDate { get; set; }
    }
}

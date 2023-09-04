using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.TempDB.Habits;

class DayOfWeek
{
    public DayOfWeek(bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, bool saturday, bool sunday)
    {
        Monday = monday;
        Tuesday = tuesday;
        Wednesday = wednesday;
        Thursday = thursday;
        Friday = friday;
        Saturday = saturday;
        Sunday = sunday;
    }
    public bool Monday { get; private set; }
    public bool Tuesday { get; private set; }
    public bool Wednesday { get; private set; } 
    public bool Thursday { get; private set; }  
    public bool Friday { get; private set;} 
    public bool Saturday { get; private set;}
    public bool Sunday { get; private set;} 
}
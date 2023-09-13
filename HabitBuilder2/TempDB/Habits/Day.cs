﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.TempDB.Habits
{
    class Day
    {
      
        public Day(bool active, string description, string icon, TimeOnly time, bool reminder)
        {
            Active = active;
            Description = description;
            Icon = icon;
            Time = time;
            Reminder = reminder;
        }


        public bool Active { get; private set; }
        public string Description { get; private set; }
        public string Icon { get; private set; }
        public TimeOnly? Time { get; private set; }
        public bool Reminder { get; private set; }

    }
}
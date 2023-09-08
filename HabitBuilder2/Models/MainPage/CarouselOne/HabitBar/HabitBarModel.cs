using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.Models.MainPage.CarouselOne.HabitBar
{
    class HabitBarModel
    {
        public string Title { get; set; }
        public int Level { get; set; }
        public string State { get; set; }
        public string Total { get; set; }

        public HabitBarModel(string title, int level, string state, string total)
        {
            Title = title;
            Level = level;
            State = state;
            Total = total;
        }
    }
}

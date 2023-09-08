using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.MainPage.CarouselOne;
using HabitBuilder2.Models.MainPage.CarouselOne.HabitBar;

namespace HabitBuilder2.ViewModels.MainPage.CarouselOne
{
   public class CarouselOneViewModel
    {
        public ObservableCollection<object> CarouselOne { get; set; }

        public CarouselOneViewModel()
        {
            CarouselOne = new ObservableCollection<object>
            {
                new HabitOverview
                {
                    Title = "Template A",
                    HabitBars = new List<HabitBarModel>()
                    {
                        new HabitBarModel("Habit A",10,"Done","10/21"),
                    }
                },
                new HabitOverview
                {
                    Title = "Template B",
                    HabitBars = new List<HabitBarModel>()
                    {
                        new HabitBarModel("Habit B",10,"Done","10/21"),
                    }
                },
                new HabitOverview
                {
                Title = "Template B",
                HabitBars = new List<HabitBarModel>()
                {
                    new HabitBarModel("Habit B",10,"Done","10/21"),
                }
            },
                new HabitOverview
                {
                Title = "Template B",
                HabitBars = new List<HabitBarModel>()
                {
                    new HabitBarModel("Habit B",10,"Done","10/21"),
                }
            }


            };


        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.ViewModels.MainPage.CarouselOne
{
    
        public class HabitOverviewHabitViewViewModel : INotifyPropertyChanged
        {
            private string _habitTitle;
            private int _habitLevel;
            private int _habitTotal;
            private int _habitStreak;

            public string HabitTitle
            {
                get => _habitTitle;
                set
                {
                    _habitTitle = value;
                    OnPropertyChanged(nameof(HabitTitle));
                }
            }

            public int HabitLevel
            {
                get => _habitLevel;
                set
                {
                    _habitLevel = value;
                    OnPropertyChanged(nameof(HabitLevel));
                }
            }

            public int HabitTotal
            {
                get => _habitTotal;
                set
                {
                    _habitTotal = value;
                    OnPropertyChanged(nameof(HabitTotal));
                }
            }

            public int HabitStreak
            {
                get => _habitStreak;
                set
                {
                    _habitStreak = value;
                    OnPropertyChanged(nameof(HabitStreak));
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

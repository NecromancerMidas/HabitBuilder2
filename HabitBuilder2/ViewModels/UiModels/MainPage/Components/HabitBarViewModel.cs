using HabitBuilder2.ViewModels.DataModels.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
using HabitBuilder2.Services.EventAggregatorArgs;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.UiModels.MainPage.Components
{
    public class HabitBarViewModel : BaseViewModel
    {
        public HabitViewModel Habit { get; set; }
        private EventAggregator _eventAggregator;
        public ICommand BarSelectedCommand { get; set; }
        private Color _statusColor;
        private string _statusText;
        public bool Selected { get; set; }
        public HabitBarViewModel(HabitViewModel habitViewModel, EventAggregator eventAggregator)
        {
            Habit = habitViewModel;
            _eventAggregator = eventAggregator;
            Debug.WriteLine(Habit.Title);
            BarSelectedCommand = new Command(() => SetSelected());
            SetStatus();
        }

        public Color StatusColor
        {
            get => _statusColor;
            set => SetField(ref _statusColor, value);
        }

        public string StatusText
        {
            get => _statusText;
            set => SetField(ref _statusText, value);
        }
        public string DisplayLevel => $"Lvl.{Habit.Level}";
        public string DisplayExperience => $"{Habit.ExperiencePoints}/21";
        // Add properties, methods, and commands specific to the HabitBar view
        // ...
        public void SetSelected()
        {
            Selected = !Selected;
            SetStatus();
            if (Selected)
            {
                _eventAggregator.SelectedItem += SelectedEventHandler;
            }
            else
            {
                _eventAggregator.SelectedItem -= SelectedEventHandler;
            }
        }

        public void SelectedEventHandler(object sender,SelectionEventArgs e)
        {
            if (e.Origin == "HabitBar" && e.Item == this)
            {
                SetSelected();
            }
        }
        public void SetStatus()
        {
            if (Selected)
            {
                StatusText = "Selected";
                StatusColor = Color.FromArgb("#a403aa");
                return;
            }
            switch (Habit.Status)
            {
                case HabitStatus.InProgress:
                    StatusText = "In Progress";
                    StatusColor = Color.FromArgb("#ff960f");
                    break;
                case HabitStatus.Frozen:
                    StatusText = "Frozen";
                    StatusColor = Color.FromArgb("#3499FE");
                    break;
                case HabitStatus.Completed:
                    StatusText = "Completed";
                    StatusColor = Color.FromArgb("#008000");
                    break;
                default:
                    StatusText = "error";
                    StatusColor = Color.FromArgb("#8000ff");
                    break;
            }
            }

        }
    }


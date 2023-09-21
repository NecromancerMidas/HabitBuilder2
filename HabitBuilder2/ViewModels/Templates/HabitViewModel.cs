using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.ViewModels.Templates
{
    public class HabitViewModel : INotifyPropertyChanged
    {


        private HabitStatus _status;
        private string _title;
        private string _description;
        private Guid _guid;
        private int _experiencePoints;
        private int _level;
        private WeekViewModel _weekDays;
        private DateTime _createdAt;
        private DateTime? _updatedAt;
        private DateTime? _deletedAt;

        public HabitStatus Status
        {
            get => _status;
            set
            {
                if (value == _status) return;
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (value == _title) return;
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public Guid Guid
        {
            get => _guid;
            set
            {
                if (value.Equals(_guid)) return;
                _guid = value;
                OnPropertyChanged(nameof(Guid));
            }
        }

        public int ExperiencePoints
        {
            get => _experiencePoints;
            set
            {
                if (value == _experiencePoints) return;
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                if (value == _level) return;
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }

        public WeekViewModel WeekDays
        {
            get => _weekDays;
            set
            {
                if (Equals(value, _weekDays)) return;
                _weekDays = value;
                OnPropertyChanged(nameof(WeekDays));
            }
        }

        public DateTime CreatedAt
        {
            get => _createdAt;
            set
            {
                if (value.Equals(_createdAt)) return;
                _createdAt = value;
                OnPropertyChanged(nameof(CreatedAt));
            }
        }

        public DateTime? UpdatedAt
        {
            get => _updatedAt;
            set
            {
                if (Nullable.Equals(value, _updatedAt)) return;
                _updatedAt = value;
                OnPropertyChanged(nameof(UpdatedAt));
            }
        }

        public DateTime? DeletedAt
        {
            get => _deletedAt;
            set
            {
                if (Nullable.Equals(value, _deletedAt)) return;
                _deletedAt = value;
                OnPropertyChanged(nameof(DeletedAt));
            }
        }




        public HabitViewModel(Habit habitModel)
        {
            _status = habitModel.Status;
            _title = habitModel.Title;
            _description = habitModel.Description;
            _guid = habitModel.Guid;
            _experiencePoints = habitModel.ExperiencePoints;
            _level = habitModel.Level;
            _weekDays = new WeekViewModel(habitModel.WeekDays);
            _createdAt = habitModel.CreatedAt;
            _updatedAt = habitModel.UpdatedAt;
            _deletedAt = habitModel.DeletedAt;
        }

        // ... [Repeat for other properties like Title, Description, etc.]

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // You can also have methods or commands to handle interactions specific to the ViewModel.
    }
}

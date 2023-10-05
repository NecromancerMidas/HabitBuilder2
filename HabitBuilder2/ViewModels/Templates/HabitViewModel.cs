using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
using Debug = System.Diagnostics.Debug;

namespace HabitBuilder2.ViewModels.Templates
{
    public class HabitViewModel : INotifyPropertyChanged, ISelectable
    {
        public enum ViewType
        {
            SpecificHabitOverviewDetails,
            SomethingElse
        }

        public ViewType CurrentView;
        public ObservableCollection<HabitViewModel> Carousel { get; set; }
        private TemplateViewModel _parent { get; set; }
        private HabitStatus _status;
        private bool _selected;
        private string _title;
        private string _description;
        private Guid _guid;
        private int _experiencePoints;
        private int _level;
        private WeekViewModel _weekDays;
        private DateTime? _createdAt;
        private DateTime? _updatedAt;
        private DateTime? _deletedAt;
        public ICommand BarSelectedCommand { get; set; }

        public HabitViewModel CloneWithViewType(ViewType viewType)
        {
            var clone = (HabitViewModel)this.MemberwiseClone();
            clone.CurrentView = viewType;
            return clone;
        }
        public HabitViewModel(Habit habitModel, TemplateViewModel parent)
        {
            _selected = false;
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
            BarSelectedCommand = new Command(() => SetSelected(!Selected));
            _parent = parent;
            Carousel = new ObservableCollection<HabitViewModel>
            {
                CloneWithViewType(ViewType.SpecificHabitOverviewDetails),
                CloneWithViewType(ViewType.SomethingElse),
            };
        }

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

        public DateTime? CreatedAt
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

        public bool Selected
        {
            get => _selected;
            set
            {
                if (value == _selected) return;
                _selected = value;
                OnPropertyChanged(nameof(Selected));
            }
        }
        

        // ... [Repeat for other properties like Title, Description, etc.]

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // You can also have methods or commands to handle interactions specific to the ViewModel.
        
        
        public void SetSelected(bool selected)
        {
            
            Debug.WriteLine("tapped");
            Debug.WriteLine(Selected);
            Selected = selected;
            _parent.SelectedItem = this;
            Debug.WriteLine(_parent.SelectedItem);
            Debug.WriteLine(Selected);
        }
    }
}

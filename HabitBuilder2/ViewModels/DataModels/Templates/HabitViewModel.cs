using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Windows.Input;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
using HabitBuilder2.ViewModels.ViewModelBase;
using Debug = System.Diagnostics.Debug;

namespace HabitBuilder2.ViewModels.DataModels.Templates
{
    public class HabitViewModel : BaseViewModel, ISelectable
    {
        public enum ViewType
        {
            SpecificHabitOverviewDetails,
            SomethingElse
        }
        public enum HabitStatus
        {
            NotStarted,
            InProgress,
            Selected,
            Frozen,
            Completed,
            Paused,
        }

        private bool _inProgress;
        private bool _isFrozen;
        private bool _isCompleted;
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
        

        public HabitViewModel CloneWithViewType(ViewType viewType)
        {
            var clone = (HabitViewModel)this.MemberwiseClone();
            clone.CurrentView = viewType;
            return clone;
        }
        public HabitViewModel(Habit habitModel, TemplateViewModel parent)
        {
            _selected = false;
            _inProgress = habitModel.InProgress;
            _isFrozen = habitModel.IsFrozen;
            _isCompleted = habitModel.IsCompleted;
            _title = habitModel.Title;
            _description = habitModel.Description;
            _guid = habitModel.Guid;
            _experiencePoints = habitModel.ExperiencePoints;
            _level = habitModel.Level;
            _weekDays = new WeekViewModel(habitModel.WeekDays);
            _createdAt = habitModel.CreatedAt;
            _updatedAt = habitModel.UpdatedAt;
            _deletedAt = habitModel.DeletedAt;
            _parent = parent;
            SetStatus();
            Carousel = new ObservableCollection<HabitViewModel>
            {
                CloneWithViewType(ViewType.SpecificHabitOverviewDetails),
                CloneWithViewType(ViewType.SomethingElse),
            };
        }

        private void SetStatus()
        {
            if (_isFrozen)
            {
                Status = HabitStatus.Frozen;
            }
            else if (_isCompleted)
            {
                Status = HabitStatus.Completed;
            }
            else
            {
                Status = HabitStatus.InProgress;
            }
        }

        public bool InProgress
        {
            get => _inProgress;
            set
            {
                SetField(ref _inProgress, value);
                HabitStatusUpdate();
            }

        }

        public void SetStatus(bool selected)
        {
            if (selected)
            {
                Status = HabitStatus.Selected;
            }
            else
            {
                SetStatus();
            }
        }
        

        public HabitStatus Status
        {
            get => _status;
            set
            => SetField(ref _status, value);
        }

        public string Title
        {
            get => _title;
            set
            => SetField(ref _title, value);
        }

        public string Description
        {
            get => _description;
            set
            => SetField(ref _description, value);
        }

        public Guid Guid
        {
            get => _guid;
            set => SetField(ref _guid, value);
        }

        public int ExperiencePoints
        {
            get => _experiencePoints;
            set
            => SetField(ref _experiencePoints, value);
        }

        public int Level
        {
            get => _level;
            set => SetField(ref _level, value);
        }

        public WeekViewModel WeekDays
        {
            get => _weekDays;
            set => SetField(ref _weekDays, value);
        }

        public DateTime? CreatedAt
        {
            get => _createdAt;
            set => SetField(ref _createdAt, value);


        }

        public DateTime? UpdatedAt
        {
            get => _updatedAt;
            set => SetField(ref _updatedAt, value);
        }

        public DateTime? DeletedAt
        {
            get => _deletedAt;
            set => SetField(ref _deletedAt, value);
        }

        public bool Selected
        {
            get => _selected;
            set => SetField(ref _selected, value);
        }

        public void SetSelected(bool selected)
        {
            throw new NotImplementedException();
        }


        // ... [Repeat for other properties like Title, Description, etc.]
        // You can also have methods or commands to handle interactions specific to the ViewModel.
        
        
        public void SetSelected()
        {
            
            Debug.WriteLine("tapped");
            Debug.WriteLine(Selected);
            Selected = !Selected;
            _parent.SelectedItem = this; //Change this to a function in the parent please.
            Debug.WriteLine(_parent.SelectedItem);
            Debug.WriteLine(Selected);
        }
        private void HabitStatusUpdate()
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.Services;
using HabitBuilder2.ViewModels.ViewModelBase;

namespace HabitBuilder2.ViewModels.DataModels.Templates
{
    public class TemplateViewModel : BaseViewModel
    {
        public enum ViewType
        {
            DetailedTemplateView,
            TemplateEditView,
            GraphsOrSomething
        }
        public ViewType CurrentView { get; set; }
        public string DisplayMode { get; set; }
        public ObservableCollection<TemplateViewModel> CarouselOneTemplate { get;set; }
        private string _title;
        private string _description;
        private Guid _id;
        private ObservableCollection<HabitViewModel> _habitList;
        private ISelectable _selectedItem;
        public HabitViewModel SelectedHabit => SelectedItem as HabitViewModel;
        public bool IsHabitSelected => SelectedItem != null;

        public TemplateViewModel(Template template)
        {
            Title = template.Title;
            Description = template.Description;
            Id = template.Id;
            HabitList = new ObservableCollection<HabitViewModel>(template.HabitList.Select(h => new HabitViewModel(h, this)));
            CarouselOneTemplate = new ObservableCollection<TemplateViewModel>
            {
                CloneWithViewType(ViewType.DetailedTemplateView),
                CloneWithViewType(ViewType.GraphsOrSomething),
            };
        }
        public TemplateViewModel CloneWithViewType(ViewType viewType)
        {
            var clone = (TemplateViewModel)this.MemberwiseClone();
            clone.CurrentView = viewType;
            return clone;
        }

        public ISelectable SelectedItem //HabitViewModel
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    // Deselect the previous item
                    if (_selectedItem != null)
                    {
                        _selectedItem.SetSelected(false);
                        
                    }

                    _selectedItem = value;

                    // Select the new item
                    if (_selectedItem != null)
                    {
                        _selectedItem.SetSelected(true);
                        
                    }
                    Debug.WriteLine(_selectedItem);
                    OnPropertyChanged(nameof(SelectedItem));
                    OnPropertyChanged(nameof(IsHabitSelected));
                }

                if (HabitList.Any(h => h.Selected)) return;
                    _selectedItem = null;
                    Debug.WriteLine(_selectedItem + " " + IsHabitSelected);
                    OnPropertyChanged(nameof(SelectedItem));
                    OnPropertyChanged(nameof(IsHabitSelected));
                
            }
        }
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public ObservableCollection<HabitViewModel> HabitList
        {
            get => _habitList;
            set
            {
                _habitList = value;
                OnPropertyChanged(nameof(HabitList));
            }
        }


        // Additional commands or methods for UI interaction can be added here.
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.ViewModels.Templates
{
    public class TemplateViewModel : INotifyPropertyChanged
    {
        private string _title;
        private string _description;
        private Guid _id;
        private ObservableCollection<HabitViewModel> _habitList;

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public TemplateViewModel(Template template)
        {
            Title = template.Title;
            Description = template.Description;
            Id = template.Id;
            HabitList = new ObservableCollection<HabitViewModel>(template.HabitList.Select(h => new HabitViewModel(h)));
        }
        // Additional commands or methods for UI interaction can be added here.
    }
}

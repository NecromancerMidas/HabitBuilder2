using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HabitBuilder2.Models;
using HabitBuilder2.Services;
using HabitBuilder2.ViewModels.Templates;

namespace HabitBuilder2.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TemplateViewModel> _templates;

        private TemplateViewModel _selectedTemplate;
        public ICommand ItemChangedCommand { get; }

        public MainPageViewModel(MainPageModel mainpage)
        {
            ItemChangedCommand = new Command<TemplateViewModel>(OnItemChanged);
            Templates =
                new ObservableCollection<TemplateViewModel>(mainpage.Templates.Select(t => new TemplateViewModel(t)));
        }
        private void OnItemChanged(TemplateViewModel newItem)
        {
            // Do something with the new item
            Console.WriteLine($"Selected item: {newItem}");
            SelectedTemplate = newItem;
        }

        public ObservableCollection<TemplateViewModel> Templates
        {
            get => _templates;
            set
            {
                _templates = value;
                OnPropertyChanged();
            }
        }

        public TemplateViewModel SelectedTemplate
        {
            get => _selectedTemplate;
            set
            {
                _selectedTemplate = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }

    



}

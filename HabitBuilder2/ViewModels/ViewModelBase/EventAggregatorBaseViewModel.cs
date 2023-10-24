using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Services;

namespace HabitBuilder2.ViewModels.ViewModelBase
{
    public class EventAggregatorBaseViewModel : BaseViewModel
    {
        protected readonly EventAggregator _eventAggregator;

        public EventAggregatorBaseViewModel(EventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.Services.EventAggregatorArgs
{
    public class SelectionEventArgs : EventArgs
    {

        public string Origin { get; set; }
        public object Item { get; set; }

        public SelectionEventArgs(string origin, object item)
        {
            Origin = origin;
            Item = item;
        }
    }
}

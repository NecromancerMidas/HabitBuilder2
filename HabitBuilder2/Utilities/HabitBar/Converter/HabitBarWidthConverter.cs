using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitBuilder2.Utilities.HabitBar.Converter
{
    class HabitBarWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int progress)
            {
                
                return (progress / 21 ) * 20;
            }
            if (value is string strValue && int.TryParse(strValue, out int result))
            {
               return (result / 21 ) * 20;
            }

            return 10;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

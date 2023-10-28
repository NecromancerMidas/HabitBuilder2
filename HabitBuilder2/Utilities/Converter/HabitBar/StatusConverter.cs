using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;

namespace HabitBuilder2.Utilities.Converter.HabitBar
{
    internal class StatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            HabitStatus status = (HabitStatus)value;
            string conversionType = (string)parameter;

            if (conversionType == "Text")
            {
                return status switch
                {
                    HabitStatus.InProgress => "In Progress",
                    HabitStatus.Frozen => "Frozen",
                    HabitStatus.Completed => "Completed",
                    _ => "Error"
                };
            }
            else if (conversionType == "Color")
            {
                return status switch
                {
                    HabitStatus.InProgress => Color.FromArgb("#ff960f"),
                    HabitStatus.Frozen => Color.FromArgb("#3499FE"),
                    HabitStatus.Completed => Color.FromArgb("#008000"),
                    _ => Color.FromArgb("#8000ff")
                };
            }

            return null;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

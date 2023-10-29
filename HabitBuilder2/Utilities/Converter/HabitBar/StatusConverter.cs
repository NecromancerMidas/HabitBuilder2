using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitBuilder2.Models.Templates;
using HabitBuilder2.ViewModels.DataModels.Templates;
namespace HabitBuilder2.Utilities.Converter.HabitBar
{
    internal class StatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            HabitViewModel.HabitStatus status = (HabitViewModel.HabitStatus)value;
            string conversionType = (string)parameter;

            if (conversionType == "Text")
            {
                return status switch
                {
                    HabitViewModel.HabitStatus.InProgress => "In Progress",
                    HabitViewModel.HabitStatus.Frozen => "Frozen",
                    HabitViewModel.HabitStatus.Completed => "Completed",
                    HabitViewModel.HabitStatus.Selected => "Selected",
                    _ => "Error"
                };
            }
            else if (conversionType == "Color")
            {
                return status switch
                {
                    HabitViewModel.HabitStatus.InProgress => Color.FromArgb("#ff960f"),
                    HabitViewModel.HabitStatus.Frozen => Color.FromArgb("#3499FE"),
                    HabitViewModel.HabitStatus.Completed => Color.FromArgb("#008000"),
                    HabitViewModel.HabitStatus.Selected => Color.FromArgb("#a403aa"),
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

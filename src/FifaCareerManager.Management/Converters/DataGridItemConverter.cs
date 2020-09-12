using System;
using System.Globalization;
using System.Windows.Data;

namespace FifaCareerManager.Management.Converters
{
    public class DataGridItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value != null && value.GetType() == targetType) ? value : null;
        }
    }
}

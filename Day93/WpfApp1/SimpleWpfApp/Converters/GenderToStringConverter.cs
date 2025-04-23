using SimpleWpfApp.Enums;
using System.Globalization;
using System.Windows.Data;

namespace SimpleWpfApp.Converters;

public class GenderToStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Gender gender)
        {
            return gender.ToString();
        }
        return "Unknown";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

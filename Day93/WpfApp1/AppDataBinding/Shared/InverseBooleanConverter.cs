﻿using System.Globalization;
using System.Windows.Data;

namespace AppDataBinding.Shared;

public class InverseBooleanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => !(bool)(value ?? false);

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => !(bool)(value ?? false);
}

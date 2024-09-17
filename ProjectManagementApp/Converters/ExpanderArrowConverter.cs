﻿using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace ProjectManagementApp.Converters
{
    public class ExpanderArrowConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isExpanded)
            {
                return isExpanded ? "▼" : "►";
            }
            return "►";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

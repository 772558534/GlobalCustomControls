﻿using System.Globalization;
using System.Windows;
using System;

using System.Windows.Media;
using System.Diagnostics;

namespace GlobalCustomControls
{
    /// <summary>
    /// A converter that takes in an Boolean and converts it to a WPF brush
    /// </summary>
    public class LightGrayToGreenByBooleanConverter : BaseValueConverter<LightGrayToGreenByBooleanConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return (bool)value ? Application.Current.FindResource("BackgroundGreenBrush") : Application.Current.FindResource("BackgroundLightGrayBrush");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class GreenToRedByBooleanConverter : BaseValueConverter<GreenToRedByBooleanConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return (bool)value ? Application.Current.FindResource("BackgroundRedBrush") : Application.Current.FindResource("BackgroundGreenBrush");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class GrayToLightByBooleanConverter : BaseValueConverter<GrayToLightByBooleanConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return (bool)value ? Application.Current.FindResource("BackgroundLightBrush") : Application.Current.FindResource("BackgroundGrayBrush");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class IntToBrushForBackgroundConverter : BaseValueConverter<IntToBrushForBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            switch (value)
            {
                case 0 or 4:
                    return new SolidColorBrush(Colors.Gray);
                case 1 or 3:
                    return new SolidColorBrush(Colors.Green);
                case 2:
                    return new SolidColorBrush(Colors.Yellow);
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class IntToBrushForForegroundConverter : BaseValueConverter<IntToBrushForForegroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            switch (value)
            {
                case 0 or 1 or 2:
                    return new SolidColorBrush(Colors.Black);
                case 3:
                    return new SolidColorBrush(Colors.Yellow);
                case 4:
                    return new SolidColorBrush(Colors.Red);
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}






using System.Globalization;
using System.Windows;
using System;
using System.Windows.Navigation;
using System.Windows.Controls;

namespace GlobalCustomControls
{
    /// <summary>
    /// A converter that takes in a boolean and returns a <see cref="Visibility"/>
    /// </summary>
    public class StatusContentConverter : BaseValueConverter<StatusContentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? Application.Current.FindResource("ExclamationIcon") : Application.Current.FindResource("OkCircleIcon");

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

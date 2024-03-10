using System.Globalization;
using System.Windows;
using System;

namespace GlobalCustomControls
{
    /// <summary>
    /// A converter that takes in a boolean and returns a <see cref="Visibility"/>
    /// </summary>
    public class BooleanToHasContentConverter : BaseValueConverter<BooleanToHasContentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
                return (bool)value ? null : "HasContent";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

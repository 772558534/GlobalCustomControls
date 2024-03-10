using System;
using System.Diagnostics;
using System.Globalization;

namespace GlobalCustomControls
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //switch ((ApplicationPage)value)
            //{
            //    case ApplicationPage.StartScreen:
            //        return new StartScreenPage();
            //    case ApplicationPage.Message:
            //        return new MessagePage();
            //    case ApplicationPage.Configuration:
            //        return new ConfigurationPage();
            //    case ApplicationPage.Status:
            //        return new StatusPage();
            //    default:
            //        Debugger.Break();
            return null;
            //}
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

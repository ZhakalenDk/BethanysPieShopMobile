using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BethanysPieShopMobile.Coverters
{
    internal class CurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format("{0:C}", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (decimal.TryParse(value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out decimal _value))
            {
                return _value;
            }

            return 0;
        }
    }
}

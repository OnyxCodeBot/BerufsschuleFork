using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace CustomConverter
{
    [ValueConversion(typeof(Decimal), typeof(String))]
    class MoneyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal money = (decimal)value;
            return money.ToString("c");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = (string)value;
            decimal result;
            if(decimal.TryParse(strValue, NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out result))
            {
                return result;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}

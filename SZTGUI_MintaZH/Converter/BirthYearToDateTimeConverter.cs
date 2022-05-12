using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SZTGUI_MintaZH.Converter
{
    internal class BirthYearToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // int to DateTime
            if (value is int i && i > 0)
            {
                return new DateTime(i, 1, 1);
            }
            return new DateTime(1970, 1, 1);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // DateTime to int
            if (value is DateTime dt)
            {
                return dt.Year;
            }
            return 1970;
        }
    }
}

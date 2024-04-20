using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.Helpers
{
    //Convert first letter in name pokemon to uppper letter
    public class FirstLetterToUpperConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string text && !string.IsNullOrEmpty(text))
            {
                return char.ToUpper(text[0]) + text.Substring(1);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();


        }
    }
}

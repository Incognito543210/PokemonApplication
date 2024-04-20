using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.Helpers
{
    //Convert height pokemon from dm to M
    public class DmToMConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is int heightInDm)
            {
                // Przekonwertuj decymetry na metry i zaokrąglij do dwóch miejsc po przecinku
                double heightInM = Math.Round(heightInDm / 10.0, 2);
                return $"{heightInM} m";
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.Helpers
{
    //Convert weight pokemon from hg to kg
    public class HgToKgConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is int weightInHg)
            {
                // Przekonwertuj hektogramy na kilogramy i zaokrąglij do dwóch miejsc po przecinku
                double weightInKg = Math.Round(weightInHg / 10.0, 2);
                return $"{weightInKg} kg";
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

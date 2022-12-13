using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelcius(double fahrenheit)
        {
            var temp = (fahrenheit - 32) / 1.8;

            return temp;
        }

        public static double CelciusToFahrenheit(double celcius)
        {
            var result = (celcius * 9) / 5 + 32;

            return result;
        }
    }
}

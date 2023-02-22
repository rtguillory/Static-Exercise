using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double Celsius)
        {
            return Celsius * 9 / 5 + 32;
        }
    }
}

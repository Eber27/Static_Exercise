using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            var degreesCelsius = (Fahrenheit - 32) / 1.8;
            return degreesCelsius;
        }

        public static double CelsiusToFahrenheit(double Celsius)
        {
            var degreesFahrenheit = (Celsius * 9) / 5 + 32;
            return degreesFahrenheit;
        }
    }
}

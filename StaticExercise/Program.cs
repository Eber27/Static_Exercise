using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var Celsius = TempConverter.FahrenheitToCelsius(25);
            Console.WriteLine($"This is {Celsius} degrees celsius.");

            var Fahrenheit = TempConverter.CelsiusToFahrenheit(40);
            Console.WriteLine($"This is {Fahrenheit} degrees fahrenheit");
        }
    }
}

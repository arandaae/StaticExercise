using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(65);
            var fahrenheit = TempConverter.CelsiusToFahreheit(20);

            Console.WriteLine($"Converting 65 degrees Fahrenheit to Celsius: {celsius}");
            Console.WriteLine();
            Console.WriteLine($"Converting 20 degrees Celsius to Fahrenheit: {fahrenheit}");
        }
    }
}

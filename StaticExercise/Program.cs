using System;
using System.Threading;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter!");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");

            var userOption = int.Parse(Console.ReadLine());

            if(userOption == 1)
            {
                Console.Write("Give a temperature in Fahrenheit: ");
                var temp = double.Parse(Console.ReadLine());

                var result = TempConverter.FahrenheitToCelsius(temp);

                Console.WriteLine($"The new temperature is {result} degrees Celsius.");
            }
            else if (userOption == 2)
            {
                Console.Write("Give a temperature in Celsius: ");
                var temp = double.Parse(Console.ReadLine());

                var result = TempConverter.CelsiusToFahrenheit(temp);

                Console.WriteLine($"The new temperature is {result} degrees Fahrenheit.");
            }
        }
    }
}

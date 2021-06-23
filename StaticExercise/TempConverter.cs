using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {

        }

        public static double FahrenheitToCelsius (double temp)
        {
            return (temp - 32) * (5.0 / 9.0);
        }

        public static double CelsiusToFahrenheit (double temp)
        {
            return (temp * 9.0 / 5.0) + 32;
        }
    }
}

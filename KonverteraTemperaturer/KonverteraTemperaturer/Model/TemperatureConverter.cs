using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonverteraTemperaturer.Model
{
    public static class TemperatureConverter
    {
        public static int CelsiusToFahrenheit(int degreesC)
        {
            int degreesF;

            degreesF = (int)Math.Round(degreesC * 1.8 + 32);

            return degreesF;
        }

        public static int FahrenheitToCelsius(int degreesF)
        {
            int degreesC;

            degreesC = (int)Math.Round((degreesF - 32) * (5.0 / 9.0));

            return degreesC;
        }
    }
}
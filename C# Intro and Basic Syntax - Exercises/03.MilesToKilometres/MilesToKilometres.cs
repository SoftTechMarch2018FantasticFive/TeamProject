// CONFIRMED from <denishristov>
// CONFIRMED from <BASTIANMARK>
// CONFIRMED <NinoBonev> 19.03.2018
using System;

namespace MilesToKilometres
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Get and parse the input data
            // Multiply it by the Miles-to-Kilometres constant
            // Round it to 2 digits after the decimal point and print it out
            Console.WriteLine($"{(double.Parse(Console.ReadLine()) * 1.60934):0.00}");
        }
    }
}

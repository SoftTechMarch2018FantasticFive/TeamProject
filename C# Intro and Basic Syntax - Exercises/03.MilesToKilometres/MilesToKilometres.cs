// CONFIRMED from <denishristov>
// CONFIRMED from <BASTIANMARK>
using System;

namespace MilesToKilometres
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Get and parse the input data
            // Multiply it by the Miles-to-kilometres constant
            // Round it to 2 digits after the decimal point and print it out
            Console.WriteLine($"{(double.Parse(Console.ReadLine()) * 1.60934):0.00}");
        }
    }
}

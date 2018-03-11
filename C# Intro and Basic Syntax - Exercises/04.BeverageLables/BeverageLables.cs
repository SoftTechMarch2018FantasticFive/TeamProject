// CONFIRMED from <denishristov>
// CONFIRMED from <BASTIANMARK>
using System;
using System.Collections.Generic;

namespace BeverageLables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Get the name of the beverage from the input 
            var name = Console.ReadLine();

            // Initialize a list of the beverage's properties
            var properties = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                // Parse and add the input data to the list
                properties.Add(double.Parse(Console.ReadLine()));  
            }

            // Print out the name and volume of the beverage
            Console.WriteLine($"{properties[0]}ml {name}:");

            // Print out it's calories and sugar
            Console.WriteLine($"{properties[1] * properties[0] / 100}kcal, {properties[2] * properties[0] / 100}g sugars");
        }
    }
}

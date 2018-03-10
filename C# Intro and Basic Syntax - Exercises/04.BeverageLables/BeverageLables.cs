using System;
using System.Collections.Generic;

namespace BeverageLables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var properties = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                properties.Add(double.Parse(Console.ReadLine()));  
            }

            Console.WriteLine($"{properties[0]}ml {name}:");

            Console.WriteLine($"{properties[1] * properties[0] / 100}kcal, {properties[2] * properties[0] / 100}g sugars");
        }
    }
}

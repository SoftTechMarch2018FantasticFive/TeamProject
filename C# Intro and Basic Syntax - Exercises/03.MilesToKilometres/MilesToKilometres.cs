using System;

namespace MilesToKilometres
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{(double.Parse(Console.ReadLine()) * 1.60934):0.00}");
        }
    }
}

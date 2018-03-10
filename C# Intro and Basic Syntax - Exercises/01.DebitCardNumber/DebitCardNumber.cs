using System;
using System.Collections.Generic;
// CONFIRMED <BASTIANMARK>

namespace DebitCardNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 4 numbers are received from the Console on separate lines.
            var card = new List<int>();
            // Create a new LIST of numbers.

            for (int i = 0; i < 4; i++)
            {
                card.Add(int.Parse(Console.ReadLine()));
                //Reads the numbers from the CONSOLE and FILLS the LIST
            }
            Console.WriteLine($"{card[0]:0000} {card[1]:0000} {card[2]:0000} {card[3]:0000}");
            // PRINTs the LIST of numbers stored in the format 0000. 
        }
    }
}

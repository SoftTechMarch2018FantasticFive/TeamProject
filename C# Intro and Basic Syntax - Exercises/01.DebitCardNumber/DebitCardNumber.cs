// CONFIRMED <BASTIANMARK>
using System;
using System.Collections.Generic;

namespace DebitCardNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 4 numbers are received from the Console on separate lines.
            // Create a new LIST of numbers.
            var card = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                //Reads the numbers from the CONSOLE and FILLS the LIST
                card.Add(int.Parse(Console.ReadLine()));
            }
            // PRINTs the LIST of numbers stored in the format 0000. 
            Console.WriteLine($"{card[0]:0000} {card[1]:0000} {card[2]:0000} {card[3]:0000}");
        }
    }
}

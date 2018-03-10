using System;
using System.Collections.Generic;

namespace DebitCardNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var card = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                card.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"{card[0]:0000} {card[1]:0000} {card[2]:0000} {card[3]:0000}");
        }
    }
}

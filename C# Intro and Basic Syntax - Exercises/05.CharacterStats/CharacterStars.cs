// CONFIRMED from <denishristov>
using System;

namespace CharacterStars
{
    class CharacterStars
    {
        static void Main(string[] args)
        {
            // Get and parse the input data
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            // Print out the name
            Console.WriteLine($"Name: {name}");
            
            // Create the Health and Energy bars and print them out
            Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.', maxHealth - currentHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', maxEnergy - currentEnergy)}|");
            
        }
    }
}

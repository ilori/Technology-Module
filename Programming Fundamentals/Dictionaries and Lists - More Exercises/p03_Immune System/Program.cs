using System;
using System.Collections.Generic;

namespace p03_Immune_System
{
    class Program
    {
        static void Main()
        {
            var totalHealth = int.Parse(Console.ReadLine());
            var currentHealth = totalHealth;
            var totalViruses = new List<string>();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var virusName = command;
                var virusStrenght = 0;
                var totalSecondsToDefeat = 0;
                foreach (var a in virusName)
                {
                    virusStrenght += a;
                }
                virusStrenght /= 3;
                totalSecondsToDefeat = virusStrenght * virusName.Length;
                if (totalViruses.Contains(virusName))
                {
                    totalSecondsToDefeat /= 3;
                }
                var minutes = totalSecondsToDefeat / 60;
                var seconds = totalSecondsToDefeat % 60;
                Console.WriteLine($"Virus {virusName}: {virusStrenght} => {totalSecondsToDefeat} seconds");
                if (totalSecondsToDefeat > totalHealth)
                {
                    Console.WriteLine($"Immune System Defeated.");
                    return;
                }
                totalHealth -= totalSecondsToDefeat;
                Console.WriteLine($"{virusName} defeated in {minutes}m {seconds}s.");
                Console.WriteLine($"Remaining health: {totalHealth}");
                totalHealth += (int) (totalHealth * 0.2);
                if (totalHealth > currentHealth)
                {
                    totalHealth = currentHealth;
                }
                totalViruses.Add(command);


                command = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {totalHealth}");
        }
    }
}
using System;

namespace p15_NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());
            var peshoHealth = 100;
            var goshoHealth = 100;
            var count = 0;
            var winner = String.Empty;
            while (peshoHealth >= 0 || goshoHealth >= 0)
            {
                count++;
                if (count % 2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                if ((count % 3 == 0 && count > 1) && (goshoHealth > 0 || peshoHealth > 0))
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }
            Console.WriteLine($"{winner} won in {count}th round.");
        }
    }
}
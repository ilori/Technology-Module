using System;
using System.Linq;

namespace p03_Endurance_Rally
{
    class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ').ToList();
            var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (var name in names)
            {
                var fuelLeft = (double) name[0];
                for (int i = 0; i < zones.Count; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuelLeft += zones[i];
                    }
                    else
                    {
                        fuelLeft -= zones[i];
                    }
                    if (fuelLeft <= 0)
                    {
                        Console.WriteLine($"{name} - reached {i}");
                        break;
                    }
                }
                if (fuelLeft > 0)
                {
                    Console.WriteLine($"{name} - fuel left {fuelLeft:f2}");
                }
            }
        }
    }
}
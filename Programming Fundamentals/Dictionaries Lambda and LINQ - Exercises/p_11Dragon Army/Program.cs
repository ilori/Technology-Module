using System;
using System.Collections.Generic;
using System.Linq;

namespace p_11Dragon_Army
{
    class Program
    {
        static void Main()
        {
            var dragonInfo = new Dictionary<string, Dictionary<string, int[]>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine();
                ManageInput(command, dragonInfo);
            }
            PrintResults(dragonInfo);
        }

        private static void PrintResults(Dictionary<string, Dictionary<string, int[]>> dragonData)
        {
            foreach (var type in dragonData)
            {
                var averageDamage = type.Value.Select(x => x.Value[0]).Average();
                var averageHealth = type.Value.Select(x => x.Value[1]).Average();
                var averageArmor = type.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine($"{type.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }

        private static void ManageInput(string command, Dictionary<string, Dictionary<string, int[]>> dragonData)
        {
            var details = command.Split();
            var type = details[0];
            var name = details[1];

            var damage = 45;
            if (details[2] != "null")
            {
                damage = int.Parse(details[2]);
            }

            var health = 250;
            if (details[3] != "null")
            {
                health = int.Parse(details[3]);
            }

            var armor = 10;
            if (details[4] != "null")
            {
                armor = int.Parse(details[4]);
            }

            if (dragonData.ContainsKey(type))
            {
                if (dragonData[type].ContainsKey(name))
                {
                    dragonData[type][name][0] = damage;
                    dragonData[type][name][1] = health;
                    dragonData[type][name][2] = armor;
                }
                else
                {
                    dragonData[type].Add(name, new[] {damage, health, armor});
                }
            }
            else
            {
                dragonData.Add(type, new Dictionary<string, int[]> {{name, new[] {damage, health, armor}}});
            }
        }
    }
}
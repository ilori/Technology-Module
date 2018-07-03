using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_Nether_Realms
{
    class Program
    {
        public static void Main()
        {
            var demon = Console.ReadLine().Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            var demons = new List<Demon>();
            foreach (var name in demon)
            {
                var demonName = name.Trim();
                var healthRegex = new Regex(@"[^+\-*\/0-9\.]");
                var healthMatch = healthRegex.Matches(demonName);
                var damageRegex = new Regex(@"[\+\-]*[0-9.]+[0-9]*");
                var damageMatch = damageRegex.Matches(demonName);
                var health = 0;
                foreach (Match match in healthMatch)
                {
                    var temp = match.ToString();
                    health += temp[0];
                }
                var damage = 0m;
                foreach (Match match in damageMatch)
                {
                    var temp = match.ToString();
                    var converted = Convert.ToDecimal(temp);
                    damage += converted;
                }
                foreach (var letter in name)
                {
                    if (letter == '*')
                    {
                        damage *= 2;
                    }
                    else if (letter == '/')
                    {
                        damage /= 2;
                    }
                }
                var currentDemon = new Demon();
                currentDemon.Name = demonName;
                currentDemon.Damage = damage;
                currentDemon.Health = health;
                demons.Add(currentDemon);
            }
            foreach (var demon1 in demons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon1.Name} - {demon1.Health} health, {demon1.Damage:f2} damage");
            }
        }
    }

    public class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }
    }
}
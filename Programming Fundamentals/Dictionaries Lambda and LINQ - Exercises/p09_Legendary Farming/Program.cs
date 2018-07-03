using System;
using System.Collections.Generic;
using System.Linq;

namespace p09_Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            var items = new Dictionary<string, long>();
            items["fragments"] = 0;
            items["shards"] = 0;
            items["motes"] = 0;
            var count = 1;
            var finishedLegendaryItem = "";
            while (count != 10)
            {
                var input = Console.ReadLine().ToLower().Split(' ').ToList();
                for (int i = 1; i < input.Count; i += 2)
                {
                    var materialQuantity = long.Parse(input[i - 1]);
                    var material = input[i];
                    if (!items.ContainsKey(material))
                    {
                        items[material] = 0;
                    }
                    items[material] += materialQuantity;

                    finishedLegendaryItem = LegendaryItem(items);


                    if (finishedLegendaryItem != "")
                    {
                        Console.WriteLine($"{finishedLegendaryItem} obtained!");
                        break;
                    }
                }
                if (finishedLegendaryItem != "")
                {
                    break;
                }
                count++;
            }
            var keyItems = items.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            var junkItems = items.Skip(3).OrderBy(x => x.Key).ToList();
            foreach (var item in keyItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static string LegendaryItem(Dictionary<string, long> items)
        {
            var finishedLegendaryItem = string.Empty;

            if (items["shards"] >= 250)
            {
                finishedLegendaryItem = "Shadowmourne";
                items["shards"] -= 250;
            }
            else if (items["motes"] >= 250)
            {
                finishedLegendaryItem = "Dragonwrath";
                items["motes"] -= 250;
            }
            else if (items["fragments"] >= 250)
            {
                finishedLegendaryItem = "Valanyr";
                items["fragments"] -= 250;
            }
            return finishedLegendaryItem;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_SoftUni_Karaoke
{
    class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList()
                .ToList();
            var songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            var result = new Dictionary<string, List<string>>();
            var performance = Console.ReadLine();
            while (performance != "dawn")
            {
                var tokens = performance.Split(',').ToList();
                var performerName = tokens[0].Trim();
                var song = tokens[1].Trim();
                var award = tokens[2].Trim();
                if (songs.Contains(song))
                {
                    if (!result.ContainsKey(performerName) && participants.Contains(performerName))
                    {
                        result[performerName] = new List<string>();
                    }
                    if (result.ContainsKey(performerName))
                    {
                        if (!result[performerName].Contains(award))
                        {
                            result[performerName].Add(award);
                        }
                    }
                }
                performance = Console.ReadLine();
            }
            if (result.Count > 0)
            {
                foreach (var res in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{res.Key}: {res.Value.Distinct().Count()} awards");
                    foreach (var award in res.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace p04CODEPhoenixOscarRomeo
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var teams = new Dictionary<string, List<string>>();
            while (input != "Blaze it!")
            {
                var tokens = input.Split(new[] {"->"}, StringSplitOptions.None).ToList();

                var creature = tokens[0].Trim();

                var squadMate = tokens[1].Trim();

                if (!teams.ContainsKey(creature))
                {
                    teams[creature] = new List<string>();
                }
                if (!teams[creature].Contains(squadMate))
                {
                    teams[creature].Add(squadMate);
                }


                input = Console.ReadLine();
            }
            var finalResult = teams
                .Select(x => new {x.Key, y = Count(teams, x.Key)})
                .OrderByDescending(x => x.y)
                .Select(x => $"{x.Key} : {x.y}");

            Console.WriteLine(string.Join(Environment.NewLine, finalResult));

        }

        private static int Count(Dictionary<string, List<string>> teams, string key)
        {
            var count = teams[key].Count;
            foreach (var mate in teams[key])
            {
                if (teams.TryGetValue(mate, out var value) && value.Contains(key))
                {
                    count--;
                }
            }
            return count;
        }
    }
}

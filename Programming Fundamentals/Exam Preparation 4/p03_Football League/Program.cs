using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_Football_League
{
    class Program
    {
        public static void Main()
        {
            var key = Console.ReadLine();

            var command = Console.ReadLine();
            var teams = new Dictionary<string, List<int>>();
            while (command != "final")
            {
                var tokens = command.Split(' ').ToList();
                var decryptedHomeTeam = tokens[0];
                var startIndex = decryptedHomeTeam.IndexOf(key, StringComparison.Ordinal);
                var endIndex = decryptedHomeTeam.LastIndexOf(key, StringComparison.Ordinal);
                var homeTeam = decryptedHomeTeam.Substring(startIndex + key.Length, endIndex - startIndex - key.Length)
                    .ToUpper()
                    .Reverse().ToArray();
                var homeTeamName = new string(homeTeam);


                var decryptedAwayTeam = tokens[1];
                startIndex = decryptedAwayTeam.IndexOf(key, StringComparison.Ordinal);
                endIndex = decryptedAwayTeam.LastIndexOf(key, StringComparison.Ordinal);
                var awayTeam = decryptedAwayTeam.Substring(startIndex + key.Length, endIndex - startIndex - key.Length)
                    .ToUpper()
                    .Reverse().ToArray();
                var awayTeamName = new string(awayTeam);
                command = Console.ReadLine();


                var result = tokens[2].Split(':');
                var homeTeamGoals = int.Parse(result[0]);
                var awayTeamGoals = int.Parse(result[1]);

                var homeTeamPoints = 0;
                var awayTeamPoints = 0;

                if (homeTeamGoals > awayTeamGoals)
                {
                    homeTeamPoints = 3;
                }
                else if (homeTeamGoals < awayTeamGoals)
                {
                    awayTeamPoints = 3;
                }
                else
                {
                    homeTeamPoints = 1;
                    awayTeamPoints = 1;
                }

                if (!teams.ContainsKey(homeTeamName))
                {
                    teams[homeTeamName] = new List<int>();
                    teams[homeTeamName].Add(homeTeamPoints);
                    teams[homeTeamName].Add(homeTeamGoals);
                }
                else
                {
                    teams[homeTeamName][0] += homeTeamPoints;
                    teams[homeTeamName][1] += homeTeamGoals;
                }
                if (!teams.ContainsKey(awayTeamName))
                {
                    teams[awayTeamName] = new List<int>();
                    teams[awayTeamName].Add(awayTeamPoints);
                    teams[awayTeamName].Add(awayTeamGoals);
                }
                else
                {
                    teams[awayTeamName][0] += awayTeamPoints;
                    teams[awayTeamName][1] += awayTeamGoals;
                }
            }
            Console.WriteLine("League standings:");
            var count = 1;
            foreach (var team in teams.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value[0]}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teams.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value[1]}");
            }
        }
    }
}
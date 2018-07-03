using System;
using System.Collections.Generic;
using System.Linq;

namespace p09_TeamworkProjects
{
    class Program
    {
        static void Main()
        {
            var teams = new Dictionary<string, Team>();
            var creators = new List<string>();
            var members = new List<string>();
            var teamCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamCount; i++)
            {
                var firstInput = Console.ReadLine().Split('-');
                var teamCreator = firstInput[0];
                var teamName = firstInput[1];
                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (creators.Contains(teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.TeamName = teamName;
                    team.TeamCreator = teamCreator;
                    teams[teamName] = team;
                    creators.Add(teamCreator);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
            }
            var secondInput = Console.ReadLine();
            while (secondInput != "end of assignment")
            {
                var tokens = secondInput.Split(new char[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = tokens[0];
                var team = tokens[1];


                if (teams.ContainsKey(team))
                {
                    if (!creators.Contains(name) && !members.Contains(name))
                    {
                        if (teams[team].TeamMembers == null)
                        {
                            teams[team].TeamMembers = new List<string>();
                        }


                        teams[team].TeamMembers.Add(name);
                        members.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"Member {name} cannot join team {team}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                secondInput = Console.ReadLine();
            }
            var disbandTeams = teams.Where(x => x.Value.TeamMembers == null).ToDictionary(x => x.Key, y => y.Value);

            foreach (var team in teams.Where(x => x.Value.TeamMembers != null)
                .OrderByDescending(x => x.Value.TeamMembers.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{team.Key}");
                Console.WriteLine($"- {team.Value.TeamCreator}");
                foreach (var member in team.Value.TeamMembers.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (var disbandTeam in disbandTeams.OrderBy(x => x.Key))
            {
                Console.WriteLine(disbandTeam.Key);
            }
        }

        public class Team
        {
            public string TeamCreator { get; set; }
            public string TeamName { get; set; }
            public List<string> TeamMembers { get; set; }
        }
    }
}
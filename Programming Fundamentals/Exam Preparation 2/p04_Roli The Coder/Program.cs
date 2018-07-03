using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_Roli_The_Coder
{
    class Program
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var participants = new Dictionary<int, Participant>();
            while (command != "Time for Code")
            {
                var tokens = command
                    .Split(new char[] {' ', '\t', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var eventId = int.Parse(tokens[0]);
                var eventName = tokens[1];
                var participantNames = tokens.Skip(2).Take(tokens.Count).ToList();
                if (eventName[0] != '#')
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (!participants.ContainsKey(eventId))
                {
                    participants[eventId] = new Participant();
                    participants[eventId].Participants = new List<string>();
                    participants[eventId].EventName = eventName;
                    participants[eventId].Participants.AddRange(participantNames);
                }
                else if (participants[eventId].EventName == eventName)
                {
                    participants[eventId].Participants.AddRange(participantNames);
                }


                command = Console.ReadLine();
            }
            foreach (var participant in participants.OrderByDescending(x => x.Value.Participants.Distinct().Count())
                .ThenBy(x => x.Value.EventName))
            {
                Console.WriteLine(
                    $"{participant.Value.EventName.Substring(1)} - {participant.Value.Participants.Distinct().Count()}");
                foreach (var name in participant.Value.Participants.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine($"{name}");
                }
            }
        }

        public class Participant
        {
            public string EventName { get; set; }
            public List<string> Participants { get; set; }
        }
    }
}
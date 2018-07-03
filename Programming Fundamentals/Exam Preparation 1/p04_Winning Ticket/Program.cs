using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_Winning_Ticket
{
    class Program
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var winning = new Regex(@"(#{6,9}|@{6,9}|\${6,9}|\^{6,9})");
            var jackpot = new Regex(@"(#{20}|@{20}|\${20}|\^{20})");

            for (int i = 0; i < tickets.Count; i++)
            {
                var ticket = tickets[i].Trim();
                if (ticket.Length == 20)
                {
                    var firstHalf = ticket.Substring(0, ticket.Length / 2);
                    var secondHalf = ticket.Substring(ticket.Length / 2);
                    var jackpotMatch = jackpot.Match(ticket);
                    var firstMatch = winning.Match(firstHalf).ToString();
                    var secondMatch = winning.Match(secondHalf).ToString();
                    if (jackpotMatch.Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {ticket.Length / 2}{ticket[0]} Jackpot!");
                        continue;
                    }
                    if (firstMatch.Length > secondMatch.Length)
                    {
                        firstMatch = firstMatch.Substring(firstMatch.Length - secondMatch.Length);
                    }
                    else if (firstMatch.Length < secondMatch.Length)
                    {
                        secondMatch = secondMatch.Substring(secondMatch.Length - firstMatch.Length);
                    }
                    if (firstMatch == secondMatch && firstMatch != "" && secondMatch != "")
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {firstMatch.Length}{firstMatch[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"invalid ticket");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Hands_of_Cards
{
    class Program
    {
        static void Main()
        {
            var playersCards = new Dictionary<string, List<string>>();
            var command = Console.ReadLine().Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "JOKER")
            {
                var name = command[0];
                var cards = command[1].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);

                if (!playersCards.ContainsKey(name))
                {
                    playersCards[name] = new List<string>();
                }

                playersCards[name].AddRange(cards);
                command = Console.ReadLine().Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            PrintTotalPlayerPoints(playersCards);
        }

        public static void PrintTotalPlayerPoints(Dictionary<string, List<string>> playersCards)
        {
            foreach (var person in playersCards)
            {
                var name = person.Key;
                var cards = person.Value.Distinct().ToList();
                var sum = 0;
                foreach (var card in cards)
                {
                    var rank = card.Substring(0, card.Length - 1).Trim();
                    var suite = card.Substring(card.Length - 1).Trim();
                    var rankPow = GetRank(rank);
                    var suitePow = GetSuite(suite);

                    sum += rankPow * suitePow;
                }
                Console.WriteLine($"{name}: {sum}");
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 0;
            }
        }

        private static int GetRank(string rank)
        {
            switch (rank)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace p02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var finalWords = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    finalWords.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ",finalWords));
        }
    }
}
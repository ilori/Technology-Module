using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Split_by_Word_Casing
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] {',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']'},
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCaseWords = new List<string>();
            var camelCaseWords = new List<string>();
            var mixedWords = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].All(char.IsLower))
                {
                    lowerCaseWords.Add(words[i]);
                }else if (words[i].All(char.IsUpper))
                {
                    camelCaseWords.Add(words[i]);
                }
                else
                {
                    mixedWords.Add(words[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", camelCaseWords)}");
        }
    }
}
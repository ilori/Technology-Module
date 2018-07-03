using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Palindromes
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] {'?', '.', ' ', '!', ','}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var result = new List<string>();
            foreach (var word in text)
            {
                if (word == string.Join("", word.Reverse()))
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", result.OrderBy(x => x)));
        }
    }
}
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
                .Where(x => x == string.Join("", x.Reverse())).OrderBy(x => x)
                .ToList().Distinct();
            Console.WriteLine(string.Join(", ", text));
        }
    }
}
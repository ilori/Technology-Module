using System;
using System.Linq;

namespace p09_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };
            var word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }
        }
    }
}
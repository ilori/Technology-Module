using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var random = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i];
                var index = random.Next(0, input.Length);
                var tempWord = input[index];
                input[i] = tempWord;
                input[index] = currentWord;
            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
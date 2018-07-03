using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Append_Lists
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var finalResult = new List<string>();
            Array.Reverse(input);
            for (int i = 0; i < input.Length; i++)
            {
                var word = input[i].Split(' ');
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] != "")
                    {
                        finalResult.Add(word[j]);
                    }
                }
            }
            
            
            
            Console.WriteLine(string.Join(" ",finalResult));
        }
    }
}
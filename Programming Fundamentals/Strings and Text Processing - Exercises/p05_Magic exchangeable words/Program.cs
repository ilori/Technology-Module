using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Magic_exchangeable_words
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var firstWord = input[0];
            var secondWord = input[1];
            var mathes = new Dictionary<char, char>();
            var exchangeable = true;

            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                if (!mathes.ContainsKey(firstWord[i]))
                {
                    if (!mathes.ContainsValue(secondWord[i]))
                    {
                        mathes[firstWord[i]] = secondWord[i];
                    }
                    else
                    {
                        exchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (mathes[firstWord[i]] != secondWord[2])
                    {
                        exchangeable = false;
                        break;
                    }
                }
            }
            var difference = string.Empty;
            if (firstWord.Length > secondWord.Length)
            {
                difference = firstWord.Substring(Math.Min(firstWord.Length, secondWord.Length));
            }
            else
            {
                difference = difference = secondWord.Substring(Math.Min(firstWord.Length, secondWord.Length));
            }
            foreach (var character in difference)
            {
                if (!mathes.ContainsKey(character) && !mathes.ContainsValue(character))
                {
                    exchangeable = false;
                    break;
                }
            }
            Console.WriteLine(exchangeable.ToString().ToLower());
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace p01_Censorship
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var sentence = Console.ReadLine();
            var match = Regex.Match(sentence, input);
            if (match.Success)
            {
                sentence = sentence.Replace(input, new string('*', input.Length));
            }
            Console.WriteLine(sentence);
        }
    }
}
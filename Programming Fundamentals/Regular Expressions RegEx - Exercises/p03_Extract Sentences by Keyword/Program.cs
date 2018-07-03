using System;
using System.Text.RegularExpressions;

namespace p03_Extract_Sentences_by_Keyword
{
    class Program
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var regex = new Regex(@"(\w[^.!?]*)?\b" + word + @"\b[^.!?]*");
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
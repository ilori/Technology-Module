using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace p09_Use_Your_Chains_Buddy
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"<p>(.+?)<\/p>");
            var matches = regex.Matches(text).Cast<Match>().Select(x => x.Groups[1].Value)
                .Select(x => Regex.Replace(x, @"[^a-z0-9]", " "))
                .Select(x => Regex.Replace(x, @"\s+", " ")).ToList();
            for (int i = 0; i < matches.Count; i++)
            {
                matches[i] = Rot13(matches[i]);
            }
            var result = new StringBuilder();
            foreach (var match in matches)
            {
                result.Append(match);
            }
            Console.WriteLine(result.ToString());
        }

        private static string Rot13(string s)
        {
            var result = new StringBuilder();
            foreach (var letter in s)
            {
                result.Append(Rot(letter));
            }
            return result.ToString();
        }

        private static char Rot(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }
            var offset = char.IsUpper(letter) ? 'A' : 'a';
            var rotated = (char) ((letter - offset + 13) % 26 + offset);
            return rotated;
        }
    }
}
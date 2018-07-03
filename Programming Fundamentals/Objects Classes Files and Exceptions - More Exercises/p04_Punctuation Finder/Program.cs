using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_Punctuation_Finder
{
    class Program
    {
        static void Main()
        {
            var text = File.ReadAllText("sample_text.txt");
            var list = Regex.Matches(text, @"(\.|,|!|\?|:)").Cast<Match>().Select(m => m.Value).ToList();
            Console.WriteLine(string.Join(", ", list));
        }
    }
}


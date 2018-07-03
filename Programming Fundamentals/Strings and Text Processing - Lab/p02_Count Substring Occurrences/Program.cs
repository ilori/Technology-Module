using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p02_Count_Substring_Occurrences
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            Console.WriteLine(Regex.Matches(Regex.Escape(text), pattern).Count);
        }
    }
}
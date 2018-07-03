using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03__Camera_View
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            var text = Console.ReadLine();
            var m = int.Parse(numbers[0]);
            var n = int.Parse(numbers[1]);
            var regex = new Regex(@"\|<\w+");
            var matches = regex.Matches(text).Cast<Match>().Select(x=>x.Value).Select(x=>string.Join("",x.Skip(m+2).Take(n))).ToList();
            Console.WriteLine(string.Join(", ",matches));
        }
    }
}
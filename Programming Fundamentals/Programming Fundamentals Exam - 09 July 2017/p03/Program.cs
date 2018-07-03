using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace p03
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var digiRegex = new Regex(@"[^A-Za-z\-]+");
            var bojoRegex = new Regex(@"[A-Za-z]+-[A-Za-z]+");
            var digiCount = 0;
            var bojoCont = 0;
            while (true)
            {
                if (digiRegex.Match(input).Success && bojoCont == digiCount)
                {
                    var digiMatch = digiRegex.Match(input).Value;
                    Console.WriteLine(digiMatch);
                    var index = input.IndexOf(digiMatch, StringComparison.Ordinal);
                    var lenght = digiMatch.Length;
                    input = input.Remove(0, index + lenght);
                    digiCount++;
                }
                else if (bojoRegex.Match(input).Success && bojoCont == digiCount - 1)
                {
                    var bojoMatch = bojoRegex.Match(input).Value;
                    Console.WriteLine(bojoMatch);
                    var index = input.IndexOf(bojoMatch, StringComparison.Ordinal);
                    var lenght = bojoMatch.Length;
                    input = input.Remove(0, index + lenght);
                    bojoCont++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
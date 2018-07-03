using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_Byte_Flip
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Where(x => x.Length == 2).ToList();

            var reversedChars = new List<string>();
            var decimalNums = new List<int>();
            var charString = new List<char>();


            foreach (var word in input)
            {
                var secondChar = word.Substring(word.Length - 1);
                var firstChar = word.Substring(0, word.Length - 1);
                var final = secondChar + firstChar;
                reversedChars.Add(final);
            }
            reversedChars.Reverse();

            foreach (var charecter in reversedChars)
            {
                decimalNums.Add(Convert.ToInt32(charecter, 16));
            }
            foreach (var num in decimalNums)
            {
                charString.Add((char)num);
            }
            Console.WriteLine(string.Join("",charString));
        }
    }
}
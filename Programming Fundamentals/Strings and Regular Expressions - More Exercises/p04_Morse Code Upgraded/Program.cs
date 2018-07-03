using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_Morse_Code_Upgraded
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|').ToList();
            var regex = new Regex(@"([1]{2,})?([0]{2,})?");
            var result = string.Empty;
            for (int i = 0; i < input.Count; i++)
            {
                var sum = 0;
                var zeroes = 0;
                var ones = 0;
                var str = input[i];
                var matches = regex.Matches(str);
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        ones++;
                    }
                    else
                    {
                        zeroes++;
                    }
                }
                foreach (Match match in matches)
                {
                    var temp1 = match.Groups[1].ToString().Length;
                    var temp2 = match.Groups[2].ToString().Length;
                    var first = temp1;
                    var second = temp2;
                    sum += first + second;
                }

                sum += zeroes * 3 + ones * 5;
                result += (char) sum;
            }
            Console.WriteLine(result);
        }
    }
}
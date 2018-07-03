using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p08_Letters_Change_Numbers
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var totalSum = new List<decimal>();
            for (int i = 0; i < input.Count; i++)
            {
                var word = input[i].Trim();
                var digits = string.Empty;
                var letters = string.Empty;
                for (int j = 0; j < word.Length; j++)
                {
                    if (char.IsDigit(word[j]))
                    {
                        digits += word[j].ToString();
                    }
                    else
                    {
                        letters += word[j];
                    }
                }
                var sum = 0m;
                for (int j = 0; j < letters.Length; j++)
                {
                    if (j == 0)
                    {
                        if (char.IsUpper(letters[j]))
                        {
                            var number = decimal.Parse(digits);
                            var letter = letters[j] % 32;
                            sum = number / letter;
                        }
                        else if (char.IsLower(letters[j]))
                        {
                            var number = decimal.Parse(digits);
                            var letter = letters[j] % 32;
                            sum = number * letter;
                        }
                    }
                    else
                    {
                        if (char.IsUpper(letters[j]))
                        {
                            var number = decimal.Parse(digits);
                            var letter = letters[j] % 32;
                            sum += -letter;
                        }
                        else if (char.IsLower(letters[j]))
                        {
                            var number = decimal.Parse(digits);
                            var letter = letters[j] % 32;
                            sum += letter;
                        }
                    }
                }
                totalSum.Add(sum);
            }
            Console.WriteLine("{0:f2}", totalSum.Sum());
        }
    }
}
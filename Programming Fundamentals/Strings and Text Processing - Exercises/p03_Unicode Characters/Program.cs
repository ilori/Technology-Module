using System;

namespace p03_Unicode_Characters
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var result = GetUni(input);
            Console.WriteLine(result.ToLower());
        }

        public static string GetUni(char[] input)
        {
            var result = string.Empty;

            foreach (var ch in input)
            {
                result += "\\u" + ((int) ch).ToString("X4");
            }
            return result;
        }
    }
}
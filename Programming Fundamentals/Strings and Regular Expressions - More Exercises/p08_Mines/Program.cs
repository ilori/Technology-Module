using System;
using System.Linq;
using System.Text;

namespace p08_Mines
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var startIndex = 0;
            var endIndex = 0;
            while ((startIndex = input.IndexOf("<", startIndex, StringComparison.Ordinal)) != -1 &&
                   (endIndex = input.IndexOf(">", startIndex, StringComparison.Ordinal)) != -1)
            {
                var bombChars = input.Substring(startIndex + 1, 2);
                var bombStrenght = BombStrenght(bombChars);
                var left = Math.Max(0, startIndex - bombStrenght);
                var right = Math.Min(input.Length - 1, endIndex + bombStrenght);

                var result = new StringBuilder(input);
                for (int i = left; i <= right; i++)
                {
                    result[i] = '_';
                }
                input = result.ToString();
            }
            Console.WriteLine(input);
        }

        private static int BombStrenght(string bombChars)
        {
            return Math.Abs(bombChars[0] - bombChars[1]);
        }
    }
}
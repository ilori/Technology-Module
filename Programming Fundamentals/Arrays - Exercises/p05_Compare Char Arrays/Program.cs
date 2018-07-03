using System;
using System.Linq;

namespace p05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var second = Console.ReadLine().Split(new char[] {' '}).Select(char.Parse).ToArray();
            var longer = GetMax(first, second);
            var isEqual = false;
            var isFirst = false;
            for (int i = 0; i < longer; i++)
            {
                if (first[i] == second[i])
                {
                    isEqual = true;
                }
                else if (first[i] < second[i])
                {
                    isFirst = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            if (isEqual && first.Length > second.Length)
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
            else if (isEqual && first.Length < second.Length)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else if (isFirst)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else if (!isFirst)
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
        }

        private static int GetMax(char[] first, char[] second)
        {
            if (first.Length >= second.Length)
            {
                return second.Length;
            }
            else
            {
                return first.Length;
            }
        }
    }
}
using System;
using System.Linq;

namespace p04_Character_Multiplier
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var first = input[0];
            var second = input[1];
            var result = GetSum(first, second);
            Console.WriteLine(result);
        }

        public static int GetSum(string first, string second)
        {
            var result = 0;
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    result += first[i] * second[i];
                }
            }
            else if (first.Length > second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    result += first[i] * second[i];
                }
                for (int i = second.Length; i < first.Length; i++)
                {
                    result += first[i];
                }
            }
            else if (first.Length < second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    result += first[i] * second[i];
                }
                for (int i = first.Length; i < second.Length; i++)
                {
                    result += second[i];
                }
            }
            return result;
        }
    }
}
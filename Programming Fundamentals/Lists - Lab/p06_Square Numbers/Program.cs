using System;
using System.Linq;

namespace p06_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int) Math.Sqrt(numbers[i]))
                {
                }
                else
                {
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
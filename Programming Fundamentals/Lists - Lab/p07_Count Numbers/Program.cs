using System;
using System.Linq;

namespace p07_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8 2 2 8 2 2 3 7
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = 1;
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        numbers.RemoveAt(j);
                        j = i;
                    }
                }
                Console.WriteLine($"{numbers[i]} -> {count}");
                numbers.RemoveAt(i);
                count = 1;
                i = -1;
            }
        }
    }
}
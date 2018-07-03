using System;
using System.Linq;

namespace p08_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var repeats = new int[65536];

            foreach (var num in numbers)
            {
                repeats[num]++;
            }

            var maxRepeats = repeats.Max();

            foreach (var num in numbers)
            {
                if (repeats[num] == maxRepeats)
                {
                    Console.WriteLine(num);
                    return;
                }
            }
        }
    }
}
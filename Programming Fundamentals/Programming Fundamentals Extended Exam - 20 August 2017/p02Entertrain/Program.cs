using System;
using System.Collections.Generic;
using System.Linq;

namespace p02Entertrain
{
    class Program
    {
        static void Main()
        {
            var power = long.Parse(Console.ReadLine());

            var finalResult = new List<long>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "All ofboard!")
                {
                    break;
                }
                var weight = long.Parse(input);
                if (weight > power)
                {
                    Console.WriteLine(power);
                    break;
                }
                finalResult.Add(weight);
                if (finalResult.Sum() > power)
                {
                    var average = (long) (finalResult.Average());
                    var closest =
                        finalResult.Aggregate((x, y) => Math.Abs(x - average) < Math.Abs(y - average) ? x : y);
                    finalResult.Remove(closest);
                }
            }
            finalResult.Reverse();
            finalResult.Add(power);
            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}
using System;
using System.Linq;

namespace p04_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList().OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
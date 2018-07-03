using System;
using System.Linq;

namespace p01_Sort_Times
{
    class Program
    {
        static void Main()
        {
            var items = Console.ReadLine().Split(' ').ToList();
            items.Sort();
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
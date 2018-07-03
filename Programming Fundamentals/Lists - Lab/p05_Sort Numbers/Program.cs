using System;
using System.Linq;

namespace p05_Sort_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
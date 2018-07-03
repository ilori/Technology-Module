using System;
using System.Linq;

namespace p06_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(word);
            Console.WriteLine(string.Join(" ",word));
        }
    }
}
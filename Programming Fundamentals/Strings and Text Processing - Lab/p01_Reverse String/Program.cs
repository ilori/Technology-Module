using System;
using System.Linq;

namespace p01_Reverse_String
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Reverse().ToList();
            Console.WriteLine(string.Join("",input));
        }
    }
}
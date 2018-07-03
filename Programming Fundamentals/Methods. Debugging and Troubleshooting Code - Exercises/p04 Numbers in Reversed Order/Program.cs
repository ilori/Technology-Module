using System;
using System.Linq;

namespace p04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseOrder());
        }

        private static string ReverseOrder()
        {
            var input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            return new string(input);
        }
    }
}
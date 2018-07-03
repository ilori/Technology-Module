using System;

namespace p14_Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number,16).ToUpper());
            Console.WriteLine(Convert.ToString(number,2).ToUpper());
        }
    }
}
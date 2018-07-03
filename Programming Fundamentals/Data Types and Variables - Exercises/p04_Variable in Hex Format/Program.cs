using System;

namespace p04_Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var hex = Console.ReadLine();
            Console.WriteLine($"{Convert.ToInt32(hex,16)}");
        }
    }
}
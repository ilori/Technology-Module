using System;
using System.Numerics;

namespace p02_Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = BigInteger.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
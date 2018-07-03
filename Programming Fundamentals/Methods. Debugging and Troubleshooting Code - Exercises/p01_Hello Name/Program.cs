using System;

namespace p01_Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            GetName(n);
        }

        private static void GetName(string s)
        {
            Console.WriteLine($"Hello, {s}!");
        }
    }
}
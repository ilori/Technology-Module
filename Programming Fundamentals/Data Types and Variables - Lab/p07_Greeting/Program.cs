using System;

namespace p07_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            var years = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {secondName}. You are {years} years old.");
        }
    }
}
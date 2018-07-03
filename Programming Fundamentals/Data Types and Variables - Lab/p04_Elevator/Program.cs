using System;

namespace p04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var elevatorCapacity = int.Parse(Console.ReadLine());
            var persons = int.Parse(Console.ReadLine());
            var courses = Math.Ceiling((double)elevatorCapacity / persons);
            Console.WriteLine($"{courses}");
        }
    }
}
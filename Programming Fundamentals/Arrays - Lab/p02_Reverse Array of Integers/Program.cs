using System;

namespace p02_Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
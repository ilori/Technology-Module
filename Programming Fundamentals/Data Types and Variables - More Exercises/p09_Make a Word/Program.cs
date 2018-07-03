using System;

namespace p09_Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lastWord = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var firstChar = Console.ReadLine();
                lastWord += firstChar;
            }
            Console.WriteLine($"The word is: {lastWord}");
        }
    }
}
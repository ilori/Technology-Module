using System;

namespace p05_Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            bool isTrue = input == "True";
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
using System;

namespace p01_X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var spaces = n - 2;
            var leftSpaces = (n - 1) / 2;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine(new string(' ', i) + "x" + new string(' ', spaces) + "x" + new string(' ', i));
                spaces -= 2;
            }
            Console.WriteLine(new string(' ', leftSpaces) + "x" + new string(' ', leftSpaces));
            spaces = 1;
            leftSpaces--;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine(new string(' ',leftSpaces) + "x" + new string(' ',spaces) + "x" + new string(' ',leftSpaces));
                leftSpaces--;
                spaces += 2;
            }
        }
    }
}
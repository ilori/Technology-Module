using System;

namespace p09_Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = new char[3];
            for (int i = 0; i < 3; i++)
            {
                var asd = char.Parse(Console.ReadLine());
                word[i] = asd;
            }
            Array.Reverse(word);
            var bla = new string(word);
            Console.WriteLine(bla);
        }
    }
}
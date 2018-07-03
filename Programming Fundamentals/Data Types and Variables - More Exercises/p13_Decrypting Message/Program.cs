using System;

namespace p13_Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());
            var finalWord = string.Empty;
            for (int i = 0; i < times; i++)
            {
                var firstChar = char.Parse(Console.ReadLine());
                finalWord += Convert.ToChar(firstChar + key);
            }
            Console.WriteLine(finalWord);
        }
    }
}
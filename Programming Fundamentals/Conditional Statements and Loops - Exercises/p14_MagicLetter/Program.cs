using System;

namespace p14_MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            var missedChar = char.Parse(Console.ReadLine());
            for (char i = firstChar; i <= secondChar; i++)
            {
                for (char j = firstChar; j <= secondChar; j++)
                {
                    for (char k = firstChar; k <= secondChar; k++)
                    {
                        if (i == missedChar || j == missedChar || k == missedChar)
                        {
                            continue;
                        }
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
using System;

namespace p05_WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            var noun = Console.ReadLine();
            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                noun += "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") ||
                     noun.EndsWith("z") || noun.EndsWith("x"))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }
            Console.WriteLine(noun);
        }
    }
}
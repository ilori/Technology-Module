using System;

namespace p15_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());
            var hasMatch = false;
x
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;

                    var endIndex = count;
                    if (count < text.Length - i)
                    {
                        var matchedString = text.Substring(i, count + 1);
                        Console.WriteLine(matchedString);
                        i += count;
                    }
                    else
                    {
                        var matchedString = text.Substring(i);
                        Console.WriteLine(matchedString);
                    }
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
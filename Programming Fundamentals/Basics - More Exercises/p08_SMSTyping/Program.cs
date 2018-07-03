using System;

namespace p08_SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = int.Parse(Console.ReadLine());
            var finalWord = String.Empty;
            for (int i = 0; i < word; i++)
            {
                var wordAFter = Console.ReadLine();
                var convertedWord = Convert.ToInt32(wordAFter);
                var mainDidgit = convertedWord % 10;
                var offset = (mainDidgit - 2) * 3;
                if (mainDidgit == 8 || mainDidgit == 9)
                {
                    offset += 1;
                }
                var letterIndex = (char) (offset + wordAFter.Length - 1 + 97);
                if (letterIndex == 91)
                {
                    finalWord += " ";
                }
                else
                {
                    finalWord += letterIndex;
                }
            }
            Console.WriteLine(finalWord);
        }
    }
}
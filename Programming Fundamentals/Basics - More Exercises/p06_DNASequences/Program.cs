using System;

namespace p06_DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var word = " ACGT";
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 1; j < word.Length; j++)
                {
                    for (int k = 1; k < word.Length; k++)
                    {
                        for (int l = 1; l < word.Length; l++)
                        {
                            if (j + k + l >= sum)
                            {
                                Console.Write($"O{word[j]}{word[k]}{word[l]}O ");
                            }
                            else
                            {
                                Console.Write($"X{word[j]}{word[k]}{word[l]}X ");
                            }
                        }
                        Console.WriteLine();
                    }
                    
                }
            }
        }
    }
}
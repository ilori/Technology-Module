using System;

namespace p03_Karate_Strings
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    i++;
                    while (i < input.Length && power > 0)
                    {
                        if (input[i] == '>')
                        {
                            break;
                        }
                        input = input.Remove(i, 1);
                        power--;
                    }
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
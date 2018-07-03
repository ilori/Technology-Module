using System;

namespace p15_Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var finalChar = string.Empty;
            var isBalanced = false;
            var trace = true;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (input != "(" && input != ")")
                {
                }
                else
                {
                    if (input == finalChar)
                    {
                        isBalanced = false;
                        break;
                    }
                    if (trace)
                    {
                        trace = false;
                        isBalanced = false;
                    }
                    else
                    {
                        trace = true;
                        isBalanced = true;
                    }
                    finalChar = input;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
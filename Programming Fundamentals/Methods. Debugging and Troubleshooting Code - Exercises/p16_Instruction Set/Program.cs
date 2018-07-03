using System;
using System.Numerics;

namespace p16_Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();
            BigInteger result = 0;
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');


                switch (codeArgs[0])
                {
                    case "INC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = operandOne;
                        result++;
                        break;
                    }
                    case "DEC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = operandOne;
                        result--;
                        break;
                    }
                    case "ADD":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "MLA":
                    {
                        var operandOne = BigInteger.Parse(codeArgs[1]);
                        var operandTwo = BigInteger.Parse(codeArgs[2]);
                        result =(BigInteger) (operandOne * operandTwo);
                        break;
                    }
                }

                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}
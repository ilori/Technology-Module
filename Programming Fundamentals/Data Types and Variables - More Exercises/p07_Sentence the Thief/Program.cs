using System;
using System.Numerics;

namespace p07_Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeralType = Console.ReadLine();
            var numberOfIds = int.Parse(Console.ReadLine());
            BigInteger closestNum = long.MinValue;
            for (int i = 0; i < numberOfIds; i++)
            {
                var id = BigInteger.Parse(Console.ReadLine());
                switch (numeralType)
                {
                    case "sbyte":
                        if (id <= sbyte.MaxValue && id > closestNum)
                        {
                            closestNum = id;
                        }
                        break;
                    case "int":
                        if (id <= int.MaxValue && id > closestNum)
                        {
                            closestNum = id;
                        }
                        break;
                    case "long":
                        if (id <= long.MaxValue && id > closestNum)
                        {
                            closestNum = id;
                        }
                        break;
                }
            }
            var penalty = 0d;
            if (closestNum < 0)
            {
                penalty = (double) closestNum / sbyte.MinValue;
            }
            else
            {
                penalty = (double) closestNum / sbyte.MaxValue;
            }
            if (penalty > 1)
            {
                Console.WriteLine($"Prisoner with id {closestNum} is sentenced to {Math.Ceiling(penalty)} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {closestNum} is sentenced to {Math.Ceiling(penalty)} year");
            }
        }
    }
}
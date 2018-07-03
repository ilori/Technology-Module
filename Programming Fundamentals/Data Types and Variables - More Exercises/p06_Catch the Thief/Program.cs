using System;
using System.Numerics;

namespace p06_Catch_the_Thief
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
            Console.WriteLine(closestNum);
        }
    }
}
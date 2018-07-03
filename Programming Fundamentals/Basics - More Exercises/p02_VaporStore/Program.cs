using System;

namespace p02_VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameOne = "OutFall 4";
            var gameTwo = "CS: OG";
            var gameThree = "Zplinter Zell";
            var gameFour = "Honored 2";
            var gameFive = "RoverWatch";
            var gameSix = "RoverWatch Origins Edition";
            var gameOnePrice = 39.99;
            var gameTwoPrice = 15.99;
            var gameThreePrice = 19.99;
            var gameFourPrice = 59.99;
            var gameFivePrice = 29.99;
            var gameSixPrice = 39.99;
            var moneySpent = 0d;
            var balance = double.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            while (command != "Game Time")
            {
                if (command != gameOne && command != gameTwo && command != gameThree && command != gameFour &&
                    command != gameFive && command != gameSix)
                {
                    Console.WriteLine("Not Found");
                }
                else if ((command == gameOne && balance < gameOnePrice) ||
                         (command == gameTwo && balance < gameTwoPrice) ||
                         (command == gameThree && balance < gameThreePrice) ||
                         (command == gameFour && balance < gameFourPrice) ||
                         (command == gameFive && balance < gameFivePrice) ||
                         (command == gameSix && balance < gameSixPrice))
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (command == gameOne || command == gameTwo || command == gameThree || command == gameFour ||
                         command == gameFive ||
                         command == gameSix)
                {
                    Console.WriteLine($"Bought {command}");
                    if (command == gameOne)
                    {
                        moneySpent += gameOnePrice;
                        balance -= gameOnePrice;
                    }
                    else if (command == gameTwo)
                    {
                        moneySpent += gameTwoPrice;
                        balance -= gameTwoPrice;
                    }
                    else if (command == gameThree)
                    {
                        moneySpent += gameThreePrice;
                        balance -= gameThreePrice;
                    }
                    else if (command == gameFour)
                    {
                        moneySpent += gameFourPrice;
                        balance -= gameFourPrice;
                    }
                    else if (command == gameFive)
                    {
                        moneySpent += gameFivePrice;
                        balance -= gameFivePrice;
                    }
                    else if (command == gameSix)
                    {
                        moneySpent += gameSixPrice;
                        balance -= gameSixPrice;
                    }
                }
                command = Console.ReadLine();
            }
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
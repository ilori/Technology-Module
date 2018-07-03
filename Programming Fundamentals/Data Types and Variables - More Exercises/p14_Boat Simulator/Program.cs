using System;
using System.Numerics;

namespace p14_Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBoat = char.Parse(Console.ReadLine());
            var secondBoat = char.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());
            var firstBoatMoves = 0;
            var secondBoatMoves = 0;
            var winner = 'a';
            for (int i = 1; i <= times; i++)
            {
                var word = Console.ReadLine();
                if (word == "UPGRADE")
                {
                    firstBoat += Convert.ToChar(3);
                    secondBoat += Convert.ToChar(3);
                }
                if (i % 2 != 0)
                {
                    firstBoatMoves += word.Length;
                }
                else
                {
                    secondBoatMoves += word.Length;
                }

                if (firstBoatMoves >= 50)
                {
                    winner = firstBoat;
                    break;
                }
                else if (secondBoatMoves >= 50)
                {
                    winner = secondBoat;
                    break;
                }
                if (firstBoatMoves <= 50 && firstBoatMoves >= secondBoatMoves)
                {
                    winner = firstBoat;
                }
                else
                {
                    winner = secondBoat;
                }
                continue;
            }
            if (secondBoatMoves == firstBoatMoves)
            {
            }
            else
            {
                Console.WriteLine(winner);
            }
        }
    }
}
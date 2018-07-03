using System;
using System.Linq;

namespace p02Icarus
{
    class Program
    {
        static void Main()
        {
            var sequnece = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var startingPosition = int.Parse(Console.ReadLine());

            var startDamage = 1;

            var input = Console.ReadLine();

            while (input != "Supernova")
            {
                var tokens = input.Split();

                var direction = tokens[0];

                var steps = int.Parse(tokens[1]);

                if (direction == "left")
                {
                    if (startingPosition - steps >= 0)
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            sequnece[startingPosition - 1] -= startDamage;
                            startingPosition--;
                        }
                    }
                    else
                    {
                        while (steps > 0)
                        {
                            startingPosition--;
                            if (startingPosition < 0)
                            {
                                startingPosition = sequnece.Length - 1;
                                startDamage++;
                            }
                            sequnece[startingPosition] -= startDamage;
                            steps--;
                        }
                    }
                }
                else if (direction == "right")
                {
                    if (startingPosition + steps <= sequnece.Length - 1)
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            sequnece[startingPosition + 1] -= startDamage;
                            startingPosition++;
                        }
                    }
                    else
                    {
                        while (steps > 0)
                        {
                            startingPosition++;
                            if (startingPosition > sequnece.Length - 1)
                            {
                                startingPosition = 0;
                                startDamage++;
                            }
                            sequnece[startingPosition] -= startDamage;
                            steps--;
                        }
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", sequnece));
        }
    }
}
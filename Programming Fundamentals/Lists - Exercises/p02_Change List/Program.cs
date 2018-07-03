using System;
using System.Linq;

namespace p02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ');
            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }


                command = Console.ReadLine().Split(' ');
            }
            if (command[0] == "Odd")
            {
                numbers.RemoveAll(x => x % 2 == 0);
            }
            else if (command[0] == "Even")
            {
                numbers.RemoveAll(x => x % 2 != 0);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
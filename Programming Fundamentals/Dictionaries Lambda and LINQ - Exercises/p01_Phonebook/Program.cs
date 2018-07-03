using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ').ToList();
            var phonebook = new Dictionary<string, string>();
            var isFound = false;
            while (names[0] != "END")
            {
                if (names[0] == "A")
                {
                    phonebook[names[1]] = names[2];
                }
                else if (names[0] == "S")
                {
                    foreach (var name in phonebook)
                    {
                        if (name.Key == names[1])
                        {
                            Console.WriteLine($"{name.Key} -> {name.Value}");
                            isFound = true;
                        }
                    }
                    if (!isFound)
                    {
                        Console.WriteLine($"Contact {names[1]} does not exist.");
                    }
                    isFound = false;
                }

                names = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
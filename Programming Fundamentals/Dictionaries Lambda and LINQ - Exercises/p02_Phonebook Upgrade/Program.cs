using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    AddEntry(input, phonebook);
                }
                else if (input[0] == "S")
                {
                    SearchEntry(input, phonebook);
                }
                else if (input[0] == "ListAll")
                {
                    PrintAllEntries(phonebook);
                }


                input = Console.ReadLine().Split(' ').ToList();
            }
        }

        private static void PrintAllEntries(Dictionary<string, string> phonebook)
        {
            foreach (var pair in phonebook.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }

        private static void SearchEntry(List<string> input, Dictionary<string, string> phonebook)
        {
            var contact = input[1];
            if (!phonebook.ContainsKey(contact))
            {
                Console.WriteLine($"Contact {contact} does not exist.");
            }
            else
            {
                Console.WriteLine($"{contact} -> {phonebook[contact]}");
            }
        }

        private static void AddEntry(List<string> input, Dictionary<string, string> phonebook)
        {
            var contact = input[1];
            var number = input[2];
            phonebook[contact] = number;
        }
    }
}
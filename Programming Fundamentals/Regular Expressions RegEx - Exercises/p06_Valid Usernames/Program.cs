    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p06_Valid_Usernames
{
    class Program
    {
        public static void Main()
        {
            var usernames = Console.ReadLine()
                .Split(new[] {'(', ')', '\\', '/', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9_]{2,24}$");
            var names = new List<string>();
            foreach (var username in usernames)
            {
                if (regex.IsMatch(username))
                {
                    names.Add(username);
                }
            }
            var lenght = 0;
            var maxLenght = 0;
            var firstWord = string.Empty;
            var secondWord = string.Empty;
            for (int i = 1; i < names.Count; i++)
            {
                lenght = names[i].Length + names[i - 1].Length;
                if (maxLenght < lenght)
                {
                    maxLenght = lenght;
                    firstWord = names[i - 1];
                    secondWord = names[i];
                }
            }
            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);
        }
    }
}
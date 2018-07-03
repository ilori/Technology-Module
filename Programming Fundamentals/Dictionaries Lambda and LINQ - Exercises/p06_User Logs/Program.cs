using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_User_Logs
{
    class Program
    {
        static void Main()
        {
            var n = Console.ReadLine()
                .Split(new char[] {'=', '\'', ' '})
                .ToList();
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            while (n[0] != "end")
            {
                var userIpAddress = n[1];
                var userName = n[7];
                var count = 1;
                if (!users.ContainsKey(userName))
                {
                    users[userName] = new Dictionary<string, int>();
                }    
                if (!users[userName].ContainsKey(userIpAddress))
                {
                    users[userName].Add(userIpAddress, count);
                }
                else
                {
                    users[userName][userIpAddress]++;
                }

                n = Console.ReadLine()
                    .Split(new char[] {'=', '\'', ' '})
                    .ToList();
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var entry in user.Value)
                {
                    if (entry.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{entry.Key} => {entry.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{entry.Key} => {entry.Value}.");
                    }
                }
            }
        }
    }
}
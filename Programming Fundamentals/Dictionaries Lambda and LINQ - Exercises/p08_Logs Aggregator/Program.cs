using System;
using System.Collections.Generic;
using System.Linq;

namespace p08_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var userInfo = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var userName = input[1];
                var ipAdress = input[0];
                var times = int.Parse(input[2]);
                if (!userInfo.ContainsKey(userName))
                {
                    userInfo[userName] = new SortedDictionary<string, int>();
                }
                if (!userInfo[userName].ContainsKey(ipAdress))
                {
                    userInfo[userName][ipAdress] = 0;
                }
                userInfo[userName][ipAdress] += times;
            }
            foreach (var user in userInfo)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} ");
                Console.Write("[");
                Console.Write(string.Join(", ", user.Value.Keys));
                Console.WriteLine("]");
            }
        }
    }
}
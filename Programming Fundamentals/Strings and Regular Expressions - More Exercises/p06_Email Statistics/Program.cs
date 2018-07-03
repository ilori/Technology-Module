using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p06_Email_Statistics
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var validEmails = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var regex = new Regex(@"([a-zA-Z]{5,})\@([a-z]{3,}\.)(bg|com|org)\b");
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    validEmails.Add(match.ToString());
                }
            }
            var result = new Dictionary<string, List<string>>();
            foreach (var email in validEmails)
            {
                var temp = email.Split('@');
                var name = temp[0];
                var domains = temp[1];
                if (!result.ContainsKey(domains))
                {
                    result[domains] = new List<string>();
                }
                if (result[domains].Contains(name))
                {
                    break;
                }
                result[domains].Add(name);
            }
            foreach (var domain in result.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");
                foreach (var name in domain.Value)
                {
                    Console.WriteLine($"### {name}");
                }
            }
        }
    }
}
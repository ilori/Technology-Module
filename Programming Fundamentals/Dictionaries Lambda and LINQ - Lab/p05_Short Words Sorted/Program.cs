using System;
using System.Linq;

namespace p05_Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '\\', '!', '?', ' ',},
                    StringSplitOptions.RemoveEmptyEntries).ToList()
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace p05_Write_to_File
{
    class Program
    {
        static void Main()
        {
            var text = File.ReadAllText("sample_text.txt");
            var list = Regex.Matches(text, @"\w+").Cast<Match>().Select(m => m.Value).ToList();
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
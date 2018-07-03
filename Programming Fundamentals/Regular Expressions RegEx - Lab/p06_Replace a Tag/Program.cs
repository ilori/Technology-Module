using System;
using System.Text.RegularExpressions;

namespace p06_Replace_a_Tag
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();


            while (text != "end")


            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";


                var replacement = @"[URL href=$1]$2[/URL]";


                var replaced = Regex.Replace(
                    text, pattern, replacement);


                Console.WriteLine(replaced);


                text = Console.ReadLine();
            }
        }
    }
}
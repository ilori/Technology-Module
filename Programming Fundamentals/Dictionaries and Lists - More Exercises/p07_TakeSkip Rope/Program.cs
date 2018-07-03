using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace p07_TakeSkip_Rope
{
    class Program
    {
        static void Main()
        {
            var wholeWord = Console.ReadLine().ToCharArray();

            var numList = new List<string>();
            var wordList = new List<string>();

            for (int i = 0; i < wholeWord.Length; i++)
            {
                if (wholeWord[i] > 47 && wholeWord[i] < 58)
                {
                    numList.Add(Convert.ToString(wholeWord[i]));
                }
                else
                {
                    wordList.Add(Convert.ToString(wholeWord[i]));
                }
            }
            var takeList = new List<int>();
            var skipList = new List<int>();

            for (int i = 0; i < numList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(Convert.ToInt32(numList[i]));
                }
                else
                {
                    skipList.Add(Convert.ToInt32(numList[i]));
                }
            }
            var finalWord = string.Empty;

            for (int i = 0; i < wordList.Count; i++)
            {
                finalWord += wordList[i];
            }
            var finalText = string.Empty;
            var sum = 0;
            for (int i = 0; i < skipList.Count; i++)
            {
                var last = finalWord.Skip(sum)
                    .Take(takeList[i]).ToArray();

                sum += skipList[i] + takeList[i];

                finalText += new string(last);
            }
            Console.WriteLine(finalText);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Longest_Increasing_Subsequence
{
    class Program
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var longestSeq = FindLongestIncreasingSubsequence(sequence);
            Console.WriteLine(string.Join(" ", longestSeq));
        }

        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            var length = new int[sequence.Length];
            var prev = new int[sequence.Length];
            var maxLength = 0;
            var lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
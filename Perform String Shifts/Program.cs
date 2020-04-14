using System;
using System.Collections.Generic;

/*
 * 
 * You are given a string s containing lowercase English letters, and a matrix shift, where shift[i] = [direction, amount]:
 * direction can be 0 (for left shift) or 1 (for right shift). 
 * amount is the amount by which string s is to be shifted.
 * A left shift by 1 means remove the first character of s and append it to the end.
 * Similarly, a right shift by 1 means remove the last character of s and add it to the beginning.
 * Return the final string after all operations.
 * 
 * Constraints:
 * 1 <= s.length <= 100
 * s only contains lower case English letters.
 * 1 <= shift.length <= 100
 * shift[i].length == 2
 * 0 <= shift[i][0] <= 1
 * 0 <= shift[i][1] <= 100
 */

namespace Perform_String_Shifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefg";
            int[][] shift = { new int[] { 1, 1 }, new int[] { 1, 1 }, new int[] { 0, 2 }, new int[] { 1, 3 } };

            Console.WriteLine(StringShift(s, shift));
        }

        public static string StringShift(string s, int[][] shift)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 0 }
            };

            foreach (var move in shift)
            {
                if (move[0] == 0)
                    dict[0] -= move[1]; // move left
                else
                    dict[1] += move[1]; // move right
            }

            int difference = dict[0] + dict[1];

            if (difference == 0) // no change needed
                return s;
            else if (difference > 0)
            {
                while (difference > 0) // shift right
                {
                    s = s.Substring(s.Length - 1, 1) + s[0..^1];
                    difference--;
                }
                return s;
            }
            else
            {
                while (difference < 0) // shift left
                {
                    s = s[1..] + s.Substring(0, 1);
                    difference++;
                }
                return s;
            }
        }
    }
}

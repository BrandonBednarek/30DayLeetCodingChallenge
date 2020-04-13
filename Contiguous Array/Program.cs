using System;
using System.Collections.Generic;

namespace Contiguous_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0 };
            Console.WriteLine(FindMaxLength(nums));
        }

        public static int FindMaxLength(int[] nums)
        {
            int difference = 0;
            int maxLength = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>
            {
                { 0, -1 }
            };

            for (int i = 0; i < nums.Length; i++)
            {
                difference += (nums[i] == 1 ? 1 : -1);
                if (dict.ContainsKey(difference))
                    maxLength = Math.Max(maxLength, i - dict[difference]);
                else
                    dict.Add(difference, i);
            }

            return maxLength;
        }
    }
}

using System;

/*
 * Given a non-empty array of integers, every element appears twice except for one. Find that single one.
 * 
 * 
 * Note:
 * Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
 */

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber(nums));
        }

        public static int SingleNumber(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[0] = nums[0] ^ nums[i];
            }
            return nums[0];
        }
    }
}

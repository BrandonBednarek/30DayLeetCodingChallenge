using System;

/*
 * Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
 * 
 * Note:
 * 1. You must do this in-place without making a copy of the array.
 * 2. Minimize the total number of operations.
 */

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }

        public static void MoveZeroes(int[] nums)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != 0)
                    nums[j++] = nums[i];

            while (j < nums.Length)
                nums[j++] = 0;

        }
    }
}

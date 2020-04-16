using System;

/*
 * Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].
 * 
 * Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.
 * Note: Please solve it without division and in O(n).
 */

namespace Product_of_Array_Except_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            nums = ProductExceptSelf(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return nums;

            int[] result = new int[nums.Length];
            result[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i - 1] * result[i - 1];
            }

            int right = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                right *= nums[i + 1];
                result[i] *= right;
            }

            return result;
        }
    }
}

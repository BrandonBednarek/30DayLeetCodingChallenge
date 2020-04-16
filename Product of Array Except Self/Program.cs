using System;

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

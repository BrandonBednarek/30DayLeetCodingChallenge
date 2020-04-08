using System;

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

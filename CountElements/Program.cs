using System;
using System.Collections.Generic;

/*
 * Given an integer array arr, count element x such that x + 1 is also in arr.
 * If there're duplicates in arr, count them seperately.
 * 
 * Constraints:
 * 1 <= arr.length <= 1000
 * 0 <= arr[i] <= 1000
 */

namespace CountElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 2 };
            Console.WriteLine(CountElements(arr));
        }

        public static int CountElements(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int i in arr)
            {
                set.Add(i);
            }

            int count = 0;

            foreach (int i in arr)
            {
                if (set.Contains(i + 1))
                    count++;
            }

            return count;
        }
    }
}

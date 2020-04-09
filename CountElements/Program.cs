using System;
using System.Collections.Generic;

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

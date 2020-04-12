using System;
using System.Collections.Generic;
using System.Linq;

/*
 * We have a collection of stones, each stone has a positive integer weight.
 * Each turn, we choose the two heaviest stones and smash them together.  Suppose the stones have weights x and y with x <= y.  The result of this smash is:
 * If x == y, both stones are totally destroyed;
 * If x != y, the stone of weight x is totally destroyed, and the stone of weight y has new weight y-x.
 * At the end, there is at most 1 stone left.  Return the weight of this stone (or 0 if there are no stones left.)
 * 
 * Note:
 * 1 <= stones.length <= 30
 * 1 <= stones[i] <= 1000
 */

namespace Last_Stone_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones = { 2, 7, 4, 1, 8, 1 };
            Console.WriteLine(LastStoneWeight(stones));
        }

        public static int LastStoneWeight(int[] stones)
        {
            List<int> list = stones.ToList();
            int difference;

            while (list.Count > 1)
            {
                list.Sort((a, b) => b.CompareTo(a)); // descending sort
                difference = list[0] - list[1];

                if (difference == 0)
                    list.RemoveRange(0, 2);
                else
                {
                    list[0] = difference;
                    list.RemoveAt(1);
                }
            }

            if (list.Count == 0)
                return 0;
            else
                return list[0];
        }
    }
}

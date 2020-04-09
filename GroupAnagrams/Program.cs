using System;
using System.Collections.Generic;

/*
 * Given an array of strings, group anagrams together.
 * 
 * Note:
 * All inputs will be in lowercase.
 * The order of your output does not matter.
 */

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> result = GroupAnagrams(strs);

            foreach (var s in result)
            {
                foreach (var s2 in s)
                {
                    Console.Write(s2 + " ");
                }
                Console.WriteLine();
            }
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> list = new List<IList<string>>();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string sorted = new string(charArray);

                if (!dict.ContainsKey(sorted))
                {
                    dict.Add(sorted, new List<string>() { word });
                }
                else
                {
                    dict[sorted].Add(word);
                }
            }

            foreach (KeyValuePair<string, List<string>> pair in dict)
            {
                list.Add(pair.Value);
            }

            return list;
        }
    }
}

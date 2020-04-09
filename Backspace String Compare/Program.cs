using System;

/*
 * Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.
 * 
 * Note:
 * 1 <= S.length <= 200
 * 1 <= T.length <= 200
 * S and T only contain lowercase letters and '#' characters.
 */

namespace Backspace_String_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "a#c";
            string T = "b";
            Console.WriteLine(BackspaceCompare(S, T));
        }

        public static bool BackspaceCompare(string S, string T)
        {
            while (S.IndexOf("#") > -1)
            {
                if (S.IndexOf("#") == 0)
                    S = S.Remove(0, 1);
                else S = S.Remove(S.IndexOf("#") - 1, 2);
            }

            while (T.IndexOf("#") > -1)
            {
                if (T.IndexOf("#") == 0)
                    T = T.Remove(0, 1);
                else T = T.Remove(T.IndexOf("#") - 1, 2);
            }
            return string.Equals(S, T);
        }
    }
}

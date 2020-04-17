using System;

/*
 * Given a string containing only three types of characters: '(', ')' and '*', write a function to check whether this string is valid. We define the validity of a string by these rules:
 * Any left parenthesis '(' must have a corresponding right parenthesis ')'.
 * Any right parenthesis ')' must have a corresponding left parenthesis '('.
 * Left parenthesis '(' must go before the corresponding right parenthesis ')'.
 * '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string.
 * An empty string is also valid.
*/

namespace Valid_Parenthesis_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "(*)))";
            Console.WriteLine(CheckValidString(s));
        }

        public static bool CheckValidString(string s)
        {
            int min = 0, max = 0;

            foreach (char c in s)
            {
                min += c == '(' ? 1 : -1;
                max += c != ')' ? 1 : -1;
                if (max < 0)
                    break;
                min = Math.Max(min, 0);
            }

            return min == 0;
        }
    }
}

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
            string s = "(*))";
            Console.WriteLine(CheckValidString(s));
        }

        public static bool CheckValidString(string s)
        {
            int leftMin = 0, leftMax = 0;

            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    leftMin++;
                    leftMax++;
                }
                else if (ch == ')')
                {
                    leftMin = Math.Max(leftMin - 1, 0);
                    leftMax--;

                    if (leftMax < 0) return false;
                }
                else
                {
                    leftMin = Math.Max(leftMin - 1, 0);
                    leftMax++;
                }
            }

            return leftMin == 0;
        }
    }
}

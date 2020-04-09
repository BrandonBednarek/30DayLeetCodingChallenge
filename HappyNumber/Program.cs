using System;

/*
 * Write an algorithm to determine if a number n is "happy".
 * 
 * A happy number is a number defined by the following process: 
 * Starting with any positive integer, replace the number by the sum of the squares of its digits, 
 * and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. 
 * Those numbers for which this process ends in 1 are happy numbers.
 * Return True if n is a happy number, and False if not.
 */

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 199;
            Console.WriteLine(IsHappy(n));
        }

        public static bool IsHappy(int n)
        {
            if (n < 10)
            {
                if (n == 1 || n == 7)
                    return true;
                else
                    return false;
            }

            int digit;
            int sum = 0;

            while (n > 0)
            {
                digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return IsHappy(sum);
        }
    }
}

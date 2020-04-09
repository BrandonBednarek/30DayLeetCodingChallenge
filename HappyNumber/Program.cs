using System;

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

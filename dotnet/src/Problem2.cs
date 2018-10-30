using System;

namespace ProjectEuler
{
    /*
    *By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    */
    public static class Problem2
    {
        public static int FibonacciEvenNumbersSum(int a, int b, int sum)
        {
            if (b < 4000000)
            {
                if (b % 2 == 0)
                {
                    sum = sum + b;
                }
                return FibonacciEvenNumbersSum(b, a + b, sum);
            }
            else
            {
                return sum;
            }
        }
    }
}
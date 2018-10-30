using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler
{
    /* 
     * Question: n! means n × (n − 1) × ... × 3 × 2 × 1
     * For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
     * and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
     * Find the sum of the digits in the number 100!
    */

    public static class Problem20
    {
        public static double FactorialDigitSum()
        {
            double resultSum = 0;
            BigInteger factorialSum = 1;
            for (int i = 1; i <= 100; i++)
            {
                factorialSum *= i;
            }

            foreach (var digit in factorialSum.ToString().Select(Char.GetNumericValue))
            {
                resultSum += digit;
            }
            return resultSum;
        }
    }
}

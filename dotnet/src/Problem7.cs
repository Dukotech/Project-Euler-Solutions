using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    /*
    * Question7:By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    * What is the 10 001st prime number?
    */

    public static class Problem7
    {
        public static int CatchPrimeNumber = 0, LastPrimeNumber = 10001;

        public static int Problem7Answer()
        {
            int n = 2, CaptureLastPrimeNumber = 0;
            do
            {
                if (IsItPrime(n))
                {
                    CaptureLastPrimeNumber = n;
                    CatchPrimeNumber++;
                }
                n++;
            } while (CatchPrimeNumber < LastPrimeNumber);
            return CaptureLastPrimeNumber;
        }

        public static bool IsItPrime(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (i == n)
                {
                    break;
                }

                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

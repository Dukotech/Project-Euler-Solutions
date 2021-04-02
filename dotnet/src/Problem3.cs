using System;

namespace ProjectEuler
{
    /*
     * Question: The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */

    public static class Problem3
    {
        public static int GetResult()
        {
            long numberTest = 600851475143;
            List<int> factors = GetFactors(numberTest);
            List<int> primeFactors = new List<int>();
            foreach (var num in factors)
            {
                if (IsPrime(num))
                {
                    primeFactors.Add(num);
                }
            }
            int largestNumber = 0;
            foreach (var number in primeFactors)
            {
                int temp = largestNumber;
                largestNumber = number;
                if (temp > largestNumber)
                {
                    largestNumber = temp;
                }
            }
            return largestNumber;
        }
        static List<int> GetFactors(long number)
        {
            List<int> factors = new List<int>();
            List<int> primeFactors = new List<int>();
            for (var i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                    factors.Add(i);
                }
            }
            return factors;
        }

        static bool IsPrime(int num)
        {
            if((GetFactors(num).Count == 1) && (num!=1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;

namespace ProjectEuler
{
    /*
     * Question: The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */

    public static class Problem3
    {
        public static int Problem3Answer()
        {
            long lastNumber = 600851475143;
            int index = 2;
            int answer = 1;
            while (true)
            {
                if (lastNumber % index == 0) //find prime number with GCD(Greatest Common Divisor) method 
                {
                    lastNumber = lastNumber / index;
                }
                if (lastNumber == 1)
                {
                    answer = index;
                    break;
                }
                index++;
            }
            return answer;
        }
    }
}
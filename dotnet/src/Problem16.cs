using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Linq;

namespace ProjectEuler
{
    /*
    * 215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    * What is the sum of the digits of the number 2^1000?
    */

    public static class Problem16
    {
        public static double Sum = 0;
        public static int Problem16Answer()
        {
            BigInteger Pow = (BigInteger)Math.Pow(2, 1000);
            var collection = Pow.ToString().Select(Char.GetNumericValue);
            foreach (var item in collection)
            {
                Sum += item;
            }
            return (Int32)Sum;
        }
    }
}

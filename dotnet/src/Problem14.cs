using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    //The following iterative sequence is defined for the set of positive integers:
    //n → n/2 (n is even)
    //n → 3n + 1 (n is odd)

    //Using the rule above and starting with 13, we generate the following sequence:

    //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

    //Which starting number, under one million, produces the longest chain?

    //NOTE: Once the chain starts the terms are allowed to go above one million.

    /// <summary>
    /// 1000000 başlayıp bu sayı içerisinde tek ise (n → 3n + 1)  çift ise (n → n/2) bu formül uygulanacak ve sayı 1 de bitmeli. bu sayılardan en uzun halka hangi sayıda olacak hadi bulalım :D 
    /// </summary>
    public static class Problem14
    {
        public static long LongChainInNumber()
        {
            long calculate = 0;
            int chainLenght = 0;
            int tempLenght = 0;
            long result=0;
            for (int i = 1; i < 1000000; i++)
            {
                chainLenght = 1;

                calculate = i;
                
                //  calculate = 13  chainLenght=10;
                while (calculate > 1)
                {
                    if (calculate % 2 != 0)
                    {
                        calculate = 3 * calculate + 1;
                    }
                    else
                    {
                        calculate = calculate / 2;
                    }

                    chainLenght++;
                }

                //max lenght in a temp
                if (chainLenght >= tempLenght)
                {
                    tempLenght = chainLenght;
                    result=i;
                }
            }

            return result;
        }


    }
}

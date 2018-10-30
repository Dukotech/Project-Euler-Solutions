using System;

namespace ProjectEuler
{
    /*
    * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    * a^2 + b^2 = c^2
    * For example, 32 + 42 = 9 + 16 = 25 = 52.
    * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    * Find the product abc.
    */

    public static class Problem9
    {
        public static double Pythagorean()
        {
            int a=0,b=0,c=1000;
            for(a = 1; a<c; a++){
                for(b = a+1; b<c; b++){
                   c = 1000 - a - b;
                   double sumofsquares = Math.Pow(a,2) + Math.Pow(b,2);
                   if(sumofsquares == Math.Pow(c,2)){
                       return a*b*c;
                   }
                }
            }
            return 0;
        } 
    }    
}
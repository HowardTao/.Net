using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_實現一個迭代器
{
   public class Primes
    {
       private long min;
       private long max;

       public Primes(long minimum, long maximum)
       {
           if (min>2)
           {
               min = 2;
           }
           else
           {
               min = minimum;
           }
           max = maximum;
       }

       public Primes()
           : this(2, 100)
       { }

       public IEnumerator GetEnumerator()
       {
           for (long possiblePrime = min; possiblePrime <= max; possiblePrime++)
           {
               bool isPrime = true;
               for (long possibleFactor = 2; possibleFactor <= (long)Math.Floor(Math.Sqrt(possiblePrime)); possibleFactor++)
               {
                   long remainderAfterDivison = possiblePrime % possibleFactor;
                   if (remainderAfterDivison == 0)
                   {
                       isPrime = false;
                       break;
                   }
               }
               if (isPrime)
               {
                   yield return possiblePrime;
               }
           }
       }
    }
}

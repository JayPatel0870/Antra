using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class PrimeNumber
    {
        public static int[] FindPrimeInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int num = startNum; num <= endNum; num++)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                }
            }
            return primes.ToArray();
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
        
}



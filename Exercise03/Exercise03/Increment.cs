using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class Increment
    {
        public void inc()
        {
            for(int i = 1; i< 5; i++)
            {
                for (int j = 0; j< 25;)
                {
                    Console.Write(j+" ");
                    

                    j = j + i;
                }
                Console.WriteLine();
            }
        }
    }
}

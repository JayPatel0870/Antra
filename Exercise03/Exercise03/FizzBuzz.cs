using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class FizzBuzz
    {
        public void FizzBuzzz(int value)
        {
            for (int i = 1; i<= value; i++)
            {
                if (i % 3 == 0 && i%5 != 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i%3 != 0 && i % 5 == 0) {
                    Console.WriteLine("buzz");
                }
                else if(i%5 == 0 && i%3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

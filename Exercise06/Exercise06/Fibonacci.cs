using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    internal class Fibonacci
    {
        public static void FibonacciSequence(int n)
        {    
            int num1 = 1;
            int num2 = 1;
            int[] arr = new int[n];
            arr[0] = num1;
            arr[1] = num2;
            for (int i = 2; i < n; i++)
            {
                arr[i] = num1 + num2;
                num1 = num2;
                num2 = arr[i];
            }

            Console.WriteLine(arr[n-1]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class RotateArray
    {
        internal static void rotateArray(int[] arr)
        {
            int n = arr.Length;
            int lastElement = arr[n - 1];  

            for (int i = n - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;  
        }
    }
}

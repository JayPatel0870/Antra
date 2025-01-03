using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class CopyingAnArray
    {
        public void copy()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[arr1.Length];

            for(int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Arr1");
            for(int i = 0;i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("Arr2");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}

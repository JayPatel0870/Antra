using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class LongestString
    {
        public static void FindLongestSequence(int[] arr)
        {
            int maxCount = 1;  
            int currentCount = 1;  
            int maxValue = arr[0];  
            int currentValue = arr[0]; 

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1]) 
                {
                    currentCount++;  
                }
                else
                {
                    if (currentCount > maxCount) 
                    {
                        maxCount = currentCount;
                        maxValue = currentValue;
                    }
                    currentCount = 1;  
                    currentValue = arr[i];  
                }
            }

            
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxValue = currentValue;
            }

            
            Console.WriteLine(string.Join(" ", new int[maxCount].Select(x => maxValue)));
        }
    }
}

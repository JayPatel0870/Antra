using System;
using System.Collections.Generic;

namespace Exercise04
{
    internal class Frequency
    {
        public static void FindMostFrequentNumber(int[] arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            int mostFrequent = arr[0];
            int maxFrequency = 0;

            foreach (var num in arr)
            {
                if (frequency[num] > maxFrequency)
                {
                    mostFrequent = num;
                    maxFrequency = frequency[num];
                }
            }

            Console.WriteLine($"The number {mostFrequent} is the most frequent (occurs {maxFrequency} times)");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class Pattern
    {
        public void printPattern()
        {
            int height = 5; // You can change the height to create a larger or smaller pyramid

            for (int i = 1; i <= height; i++)
            {
                // Print spaces
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}

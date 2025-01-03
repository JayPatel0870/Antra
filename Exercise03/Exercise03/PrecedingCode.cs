using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class PrecedingCode
    {
        public void method() {
            int max = 500;
            if (max > byte.MaxValue)
            {
                Console.WriteLine("Warning: The value of 'max' exceeds the maximum value of byte (127).");
            }
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
            }
    }
}

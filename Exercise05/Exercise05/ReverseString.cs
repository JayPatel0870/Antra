using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class ReverseString
    {
        public void reverseString()
        {
            Console.WriteLine("Enter Your String: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString1 = new string(charArray);
            Console.WriteLine("Output1");
            Console.WriteLine(reversedString1);

            string reversedString2 = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString2 += input[i];
            }
            Console.WriteLine("Output2");
            Console.WriteLine(reversedString2);
        }
    }
}

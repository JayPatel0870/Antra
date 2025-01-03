using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class IsPalindrome
    {
        public bool Check(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (char.ToLower(word[left]) != char.ToLower(word[right]))
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}

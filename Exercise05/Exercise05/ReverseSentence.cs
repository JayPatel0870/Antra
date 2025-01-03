using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class ReverseSentence
    {
        public static string ReverseWords(string sentence)
        {
            string pattern = @"([.,:;=()&\[\]\\\'\\/!?\s]+)";

            string[] parts = Regex.Split(sentence, pattern);

            List<string> words = new List<string>();

            foreach (string part in parts)
            {
                if (!Regex.IsMatch(part, pattern) && !string.IsNullOrEmpty(part))
                {
                    words.Add(part);
                }
            }

            words.Reverse();

            int wordIndex = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (!Regex.IsMatch(parts[i], pattern) && !string.IsNullOrEmpty(parts[i]))
                {
                    parts[i] = words[wordIndex++];
                }
            }

            return string.Join("", parts);
        }

    }
}

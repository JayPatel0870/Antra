using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reverse Words with two different methods
            //ReverseString rs = new ReverseString();
            //rs.reverseString();

            // reverse Sentence 
            //string input = "C# is not C++, and PHP is not Delphi!";
            ////string input = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
            //string output = ReverseSentence.ReverseWords(input);
            //Console.WriteLine(output);

            // Palindrome
            //Console.WriteLine("Enter a sentence:");
            //string input = Console.ReadLine();

            //string[] words = Regex.Split(input, "[^a-zA-Z]+").Where(w => w.Length > 0).ToArray();

            //List<string> palindromes = new List<string>();
            //foreach (string word in words)
            //{
            //    if (IsPalindrome.Check(word)) 
            //    {
            //        palindromes.Add(word);
            //    }
            //}

            //string[] sortedPalindromes = palindromes.Distinct(StringComparer.OrdinalIgnoreCase)
            //                                        .OrderBy(p => p, StringComparer.OrdinalIgnoreCase)
            //                                        .ToArray();

            //Console.WriteLine("Palindromes in sorted order:");
            //Console.WriteLine(string.Join(", ", sortedPalindromes));

            // ParseURL
            Console.WriteLine("Enter a URL:");
            string input = Console.ReadLine();

            // Call the ParseURL function to extract protocol, server, and resource
            ParseURL.ParseUrl(input);






        }
    }
}


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6.Palindromes
{
    public class Palindromes
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var word = Regex.Matches(input, @"\b\w+\b");
            var matches = word.Cast<Match>().Select(m => m.Value).OrderBy(m => m);
              
          
            foreach (var words in matches)
            {
                if (IsPalindrome(words))
                {
                    Console.Write(string.Join(", ", words));
                }
            }
            Console.WriteLine();
            
        }

        static bool IsPalindrome(string word)
        {
            return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
        }
    }
}

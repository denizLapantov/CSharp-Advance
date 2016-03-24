namespace _1.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\w)\1*";
            new Regex(pattern);
            var a = Regex.Replace(input, pattern, "$1");
            Console.WriteLine(a);
        }
    }
}

namespace _3.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patternMeil = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            Regex regexMail = new Regex(patternMeil);
            MatchCollection matches = regexMail.Matches(text);
            Console.WriteLine("Found {0} matches", matches.Count);
            foreach (Match name in matches)
            {
                Console.WriteLine(name.Groups[0]);
            }
        }
    }
}

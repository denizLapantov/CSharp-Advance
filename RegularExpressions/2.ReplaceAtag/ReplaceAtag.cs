namespace _2.ReplaceAtag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceAtag
    {
        public static void Main(string[] args)
        {
            string input = "<ul> <li> <a href=http://softuni.bg>SoftUni</a> </li> </ul>";
            string pattern = @"<a href=(?:(?<link>[^>]*))>(?:(?<name>\w*))<\/a>";
            Regex reg = new Regex(pattern);
            var result = Regex.Replace(input, pattern, "[URL href=${link}]${name}[/URL]");
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;
using System.Net.Mime;

namespace _4.TextFilter
{
    public class Program
    {
        public static void Main()
        {
            string[] banList = Console.ReadLine().Split(',');

            string text = Console.ReadLine();

            foreach (var ban in banList)
            {
                string replace = new string('*', ban.Length);
                text = text.Replace(ban, replace);
            }

            Console.WriteLine(text);
        }
    }
}

using System;
using System.Text;

namespace _5.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetUniCode(input));
        }

        private static string GetUniCode(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in input)
            {
                sb.Append("\\u");
                sb.Append(string.Format("{0:x4}", (int)ch));
            }

            return sb.ToString();
        }
    }
}

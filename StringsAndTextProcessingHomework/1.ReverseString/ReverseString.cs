namespace _1.ReverseString
{
    using System;
    using System.Linq;
    
    public class ReverseString
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input != null)
            {
                Console.WriteLine(string.Join("", input.Reverse()));
            }
        }
    }
}
 
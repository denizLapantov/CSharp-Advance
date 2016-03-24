namespace _2.StringLength
{
    using System;

    public class StringLenght
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (input != null && input.Length < 20)
            {
                Console.WriteLine(input +  new string('*' , 20 - input.Length));

            }
            else
            {
                if (input != null) Console.WriteLine(input.Substring(0, 20));
            }
            
        }
    }
}

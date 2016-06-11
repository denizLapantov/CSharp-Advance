using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10.GroupByGroup
{
    public class GroupByGroup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> numbers = new Dictionary<string, int>();

            while (input != "END")
            {

                string[] info = input.Split();

                string names = info[0] + " " + info[1];
                int number = int.Parse(info[2]);
                
                if (!numbers.ContainsKey(names))
                {
                    numbers.Add(names, number);
                }
              
                input = Console.ReadLine();
            }

            var sorted = numbers.OrderBy(x => x.Value).GroupBy(y => y.Value);
            foreach (var number in sorted)
            {
                Console.Write($"{number.Key + " - "}");
                List<string> myList = new List<string>();

                foreach (var name in number)
                {
                    myList.Add(name.Key);
                }
                Console.Write(string.Join(", ",myList));
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FilterStudentsByPhone
{
    public class FilterStudentsByPhone
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> myList = new List<string>();

            while (input != "END")
            {
                myList.Add(input);

                input = Console.ReadLine();
            }

            var result = myList.Select(x => x.Split()).Where(x => x[2].StartsWith("02") || x[2].StartsWith("+3592")).ToList();
            foreach (var name in result)
            {
                Console.WriteLine(name[0] + " " + name[1]);
            }
        }
    }
}

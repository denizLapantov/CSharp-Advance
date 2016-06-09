using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsByFirstAndLastName
{
    public class StudentsByFirstAndLastName
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> myList = new List<string>();

            while (input !="END")
            {
                myList.Add(input);
                input = Console.ReadLine();
            }

            var result = myList.Select(x => x.Split()).Where(x => x[1].CompareTo(x[0]) == 1).ToList();

            foreach (var name in result)
            {
                Console.WriteLine(name[0] + " " + name[1]);
            }
        }
    }
}

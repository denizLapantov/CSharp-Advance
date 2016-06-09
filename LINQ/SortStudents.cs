using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SortStudents
{
    public class SortStudents
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> myList = new List<string>();

            while (input != "END")
            {
                myList.Add(input);

                input = Console.ReadLine();
            }

            var result = myList.Select(x=>x.Split()).OrderBy(x=>x[1]).ThenByDescending(x=>x[0]);
            foreach (var name in result)
            {
                Console.WriteLine(name[0] + " " + name[1]);
            }

        }
    }
}

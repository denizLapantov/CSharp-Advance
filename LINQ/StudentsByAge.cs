using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.StudentsByAge
{
    public class StudentsByAge
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

            var result =
                myList.Select(x => x.Split()).Where(x => int.Parse(x[2]) >= 18 && int.Parse(x[2]) <= 24).ToList();

            foreach (var name  in result)
            {
                Console.WriteLine(name[0] + " " + name[1] + " " + name[2]);
            }
        }
    }
}

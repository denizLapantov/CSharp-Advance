using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.StudentsEnrolledIn2014Or2015
{
    public class StudentsEnrolledIn2014Or2015
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, List<int>> personInfo = new Dictionary<string, List<int>>();

            while (input[0] != "END")
            {
                string firstName = input[0];

                if (!personInfo.ContainsKey(firstName))
                {
                    personInfo.Add(firstName, new List<int>());
                }
                for (int i = 1; i < input.Length; i++)
                {
                    personInfo[firstName].Add(int.Parse(input[i]));
                }

            

                input = Console.ReadLine().Split();
            }

            var sort = personInfo.Where(x => x.Key.EndsWith("14") || x.Key.EndsWith("15"));

            foreach (var outerr in sort)
            {
                Console.WriteLine(string.Join(" ",outerr.Value));
            }

        }
    }
}

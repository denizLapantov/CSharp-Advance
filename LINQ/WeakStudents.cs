using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.WeakStudents
{
    public class WeakStudents
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string,List<int>> personInfo = new Dictionary<string, List<int>>();

            while (input[0] != "END")
            {
                string firstName = input[0] + " " + input[1];
          
                if (!personInfo.ContainsKey(firstName))
                {
                    personInfo.Add(firstName, new List<int>());
                }
                for (int i = 2; i < input.Length; i++)
                {
                    personInfo[firstName].Add(int.Parse(input[i]));
                }
           
                personInfo[firstName].Sort();

                input = Console.ReadLine().Split();
            }


            var sort = personInfo.Where(x => x.Value.Min() <= 3 && x.Value.Skip(1).Min() <= 3);

            foreach (var names in sort)
            {
                Console.WriteLine(names.Key);
            }
           
        }
    }
}

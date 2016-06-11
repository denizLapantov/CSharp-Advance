using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.OfficeStuff
{
    public class OfficeStuff
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string,Dictionary<string,int>> data = new SortedDictionary<string, Dictionary<string,int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] {' ', '|', '\t', '-'},StringSplitOptions.RemoveEmptyEntries);

                string company = input[0].Trim();
                int amount = int.Parse(input[1].Trim());
                string product = input[2].Trim();

                if (!data.ContainsKey(company))
                {
                    data.Add(company, new Dictionary<string, int>());
                }
                if (!data[company].ContainsKey(product))
                {
                    data[company].Add(product,0);
                }
                data[company][product] +=amount;

            }

            foreach (var outerPair in data)
            {
                Console.Write(outerPair.Key + ": ");
                var result = new List<string>();
                result.AddRange(outerPair.Value.Select(x => $"{x.Key}-{x.Value}"));
                Console.WriteLine(string.Join(", ",result));
             }
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.LittleJohn
{
    public class LittleJohn
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"([>]{3}-----[>]{2})|([>]{2}-----[>]{1})|([>]{1}-----[>]{1})");
            Dictionary<string,int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("large",0);
            myDictionary.Add("medium", 0);
            myDictionary.Add("small", 0);


            for (int i = 0; i <= 4; i++)
            {
                MatchCollection match = pattern.Matches(input);
                if (match.Count > 0)
                {
                    foreach (Match arrow in match)
                    {
                        if (arrow.Value == ">>>----->>")
                        {
                            myDictionary["large"]++;
                        }
                        else if (arrow.Value == ">>----->")
                        {
                            myDictionary["medium"]++;
                        }
                        else 
                        {
                            myDictionary["small"]++;
                        }
                    }
                }

                input = Console.ReadLine();

            }

            string result = myDictionary["small"] + myDictionary["medium"].ToString() + myDictionary["large"];
         

            int resultNum = int.Parse(result);
            result = Convert.ToString(resultNum, 2);
            //   int finalResult = 0;
             Console.WriteLine(result);
            StringBuilder stringBuilder = new StringBuilder(result);
            Console.WriteLine(stringBuilder);
            for (int i = result.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(result[i]);
            }
            Console.WriteLine(stringBuilder);
            Console.WriteLine(Convert.ToInt16(stringBuilder.ToString(),16));

 

        }
    }
}

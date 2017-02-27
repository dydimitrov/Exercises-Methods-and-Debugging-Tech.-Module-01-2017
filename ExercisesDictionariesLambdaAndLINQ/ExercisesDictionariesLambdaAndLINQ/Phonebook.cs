using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesDictionariesLambdaAndLINQ
{
    public class Phonebook
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var resultDict = new Dictionary<string, string>();
            
            while (input[0]!="END")
            {
               switch (input[0])
                {
                    case "A":
                        if (resultDict.ContainsKey(input[1]))
                        {
                            resultDict[input[1]] = input[2];
                        }
                        else
                        {
                            resultDict.Add(input[1], input[2]);
                        }
                        break;

                    case "S":
                        
                        if (!resultDict.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                           
                        }
                        else
                        {
                            foreach (var item in resultDict)
                            {
                                if (item.Key==input[1])
                                {
                                    Console.WriteLine($"{item.Key} -> {item.Value}");
                                }
                            }
                        }
                        break;
                }
                input = Console.ReadLine().Split().ToArray();

            }
        }
    }
}

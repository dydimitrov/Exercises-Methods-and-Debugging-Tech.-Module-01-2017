using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    public class UserLogs
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var result = new SortedDictionary<string, List<string>>();
            
            while (line != "end")
            {
                var nameIpMessage = line.Split();
                var nameArray = nameIpMessage[2].Split('=');
                var ipArray = nameIpMessage[0].Split('=');
                var name = nameArray[1];
                var iP = ipArray[1];

                if (!result.ContainsKey(name))
                {
                    result[name]=new List<string>();
                    
                }
                result[name].Add(iP);

                line =Console.ReadLine();

            }
            
            foreach (var item in result)
            {
                var lastDict = new Dictionary<string, int>();
                Console.WriteLine($"{item.Key}: ");
                
                foreach (var log in item.Value)
                {
                    
                    if (!lastDict.ContainsKey(log))
                    {
                        lastDict.Add(log, 1);
                    }
                    else
                    {
                        lastDict[log]++;
                    }
                }
                foreach (var iP in lastDict)
                {
                    if (iP.Key != lastDict.Keys.Last())
                    {
                        Console.Write($"{iP.Key} => {iP.Value}, ");
                    }
                    else Console.WriteLine($"{iP.Key} => {iP.Value}.");
                    
                }
            }
        }
    }
}

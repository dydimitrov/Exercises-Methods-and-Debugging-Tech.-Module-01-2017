using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 1; i <= numberOfLines; i++)
            {
                var line = Console.ReadLine().Split().ToArray();
                var name = line[1];
                var iP = line[0];
                var time = int.Parse(line[2]);

                if (!result.ContainsKey(name))
                {
                    result[name] = new Dictionary<string, int>();
                }
                foreach (var item in result.Values)
                {
                    if (!item.ContainsKey(iP))
                    {
                        result[name][iP] = time;

                    }
                    else
                    {
                        item[iP] += time;
                    }
                }
                
            }
            foreach (var item in result)
            {
                Console.Write($"{item.Key}: ");
                var lastDictionary = new Dictionary<string, int>();
                foreach (var value1 in item.Value)
                {
                    lastDictionary[value1.Key] = value1.Value;
                }
                Console.WriteLine($"{ lastDictionary.Values.Sum()} { string.Join(", ", lastDictionary.Keys)}");
            }
        }
    }
}

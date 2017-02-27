using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    public class MinerTask
    {
        public static void Main(string[] args)
        {
            var line =Console.ReadLine();
            var resultDict = new Dictionary<string, int>();
            while (line !="stop")
            {
                var resource = line;
                var quantity = int.Parse(Console.ReadLine());
                if (! resultDict.ContainsKey(resource))
                {
                    resultDict[resource] = 0;
                }
                resultDict[resource] += quantity;
                line =Console.ReadLine();

            }
            foreach (var item in resultDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

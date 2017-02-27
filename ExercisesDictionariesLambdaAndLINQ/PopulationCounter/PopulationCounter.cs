using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<string,long>>();

            while (line != "report")
            {
                var townCountryPop = line.Split('|');
                var town = townCountryPop[0];
                var country = townCountryPop[1];
                var population= int.Parse(townCountryPop[2]);


                if (!result.ContainsKey(country))
                {
                    result[country] = new Dictionary<string,long>();

                }
                result[country][town] = population;
               

                line = Console.ReadLine();

            }
            foreach (var item in result.OrderByDescending(x => x.Value.Values.Sum()))
            {
                var lastDictionary = new Dictionary<string, long>();
                
                foreach (var value1 in item.Value)
                {
                    if (!lastDictionary.ContainsKey(value1.Key))
                    {
                        lastDictionary.Add(value1.Key,value1.Value);
                    }
                    else
                    {
                        lastDictionary[value1.Key] += value1.Value;
                    }
                }
                Console.WriteLine($"{item.Key} (total population: {lastDictionary.Values.Sum()})");
                foreach (var town in lastDictionary.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
            }
        }
    }
}

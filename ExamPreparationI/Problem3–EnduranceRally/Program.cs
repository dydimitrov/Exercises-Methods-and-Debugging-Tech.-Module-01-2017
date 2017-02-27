using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_EnduranceRally
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gamers = Console.ReadLine().Split().ToArray();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var driver in gamers)
            {
                var startFuel = Fuel(driver);
                var sumOfFuel = startFuel;
                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        sumOfFuel += zones[i];
                    }
                    else
                    {
                        sumOfFuel -= zones[i];
                    }
                    if (sumOfFuel<=0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                    if (i==zones.Length-1)
                    {
                        Console.WriteLine($"{driver} - fuel left {sumOfFuel:f2}");
                    }
                }
            }
                
        }
        public static double Fuel(string str)
        {
            var fuel = (double)str[0];
            return fuel;
        }
    }
}

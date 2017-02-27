using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var maratonLengthDays = long.Parse(Console.ReadLine());
            var numberOfParticipate = long.Parse(Console.ReadLine());
            var avarageLapsPerRuner = long.Parse(Console.ReadLine());
            var lengthOfTrack = long.Parse(Console.ReadLine());
            var capacityOfTrack = long.Parse(Console.ReadLine());
            var moneyDonate = decimal.Parse(Console.ReadLine());

            var maxRunners = maratonLengthDays * capacityOfTrack;
            var actualRunners = 0l;
            if (maxRunners<numberOfParticipate)
            {
                actualRunners = maxRunners;
            }
            else
            {
                actualRunners = numberOfParticipate;
            }
            var totalKilometers = ((actualRunners*lengthOfTrack) * avarageLapsPerRuner)/1000;
            var moneyRisedFromMaraton = totalKilometers * moneyDonate;
            Console.WriteLine($"Money raised: {moneyRisedFromMaraton:f2}");

        }
    }
}

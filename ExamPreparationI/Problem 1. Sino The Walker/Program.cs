using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Problem_1.Sino_The_Walker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputTime = new DateTime();
            inputTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            var steps = double.Parse(Console.ReadLine());
            var secondsPerStep = double.Parse(Console.ReadLine());
            double timeToAdd = steps * secondsPerStep;

            DateTime result = inputTime.AddSeconds(timeToAdd);
            Console.WriteLine($"Time Arrival: {result:HH:mm:ss}");

        }
    }
}

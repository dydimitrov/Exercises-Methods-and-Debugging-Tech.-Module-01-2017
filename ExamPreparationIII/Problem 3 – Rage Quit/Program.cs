using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3___Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);

            var inputLine = Console.ReadLine().ToUpper();

            MatchCollection matches = regex.Matches(inputLine);

            StringBuilder output = new StringBuilder();

            foreach (Match match in matches)
            {
                string message = match.Groups[1].Value;
                int repeats = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < repeats; i++)
                {
                    output.Append(message);
                }
            }
            Console.WriteLine("Unique symbols used: {0}",output.ToString().Distinct().Count());
            Console.WriteLine(output.ToString());
        }
    }
}

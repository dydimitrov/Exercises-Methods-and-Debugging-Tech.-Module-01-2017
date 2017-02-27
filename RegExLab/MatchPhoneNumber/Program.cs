using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "359-2-222-2222, +359/2/222/2222, +359 2 222 2222, +359 2-222-2222, +359-2-222-2222, +359-2-222-22222";
            var regEx = new Regex(@"\+\d{3}(\s|-)\d{1}\1\d{3}\1\d{4}\b");

            var matches = regEx.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

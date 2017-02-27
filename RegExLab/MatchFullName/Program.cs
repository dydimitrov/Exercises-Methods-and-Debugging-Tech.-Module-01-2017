using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var text = "ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	Ivanov";
            var regEx = new Regex(@"\b[A-Z][a-z]{1,}\s[A-Z][a-z]{1,}\b");

            var result = regEx.Matches(text);

            foreach (Match match in result)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

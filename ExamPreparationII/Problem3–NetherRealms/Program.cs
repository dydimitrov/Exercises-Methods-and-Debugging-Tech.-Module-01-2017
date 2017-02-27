using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem3_NetherRealms
{
    class Program
    {
        public static void Main(string[] args)
        {
            var namesOfDemons = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .OrderBy(x => x).ToArray();
            var regExHealth = new Regex(@"[^0-9+\-*\/\.]");
            var regExDamage = new Regex(@"[+-]?\d+(?:\.?\d+)?");
            var regExSpcial = new Regex(@"[*\/]?");

            foreach (var demon in namesOfDemons)
            {
                var healthString = regExHealth.Matches(demon);
                var damageString = regExDamage.Matches(demon);
                var specialString = regExSpcial.Matches(demon);
            //this is for health
                var healthSum = new List<string>();
                foreach (Match item in healthString)
                {
                    healthSum.Add(item.Value);
                }
                var stringToMethod = string.Join("", healthSum).Trim();
                var actSum = GetSumAscii(stringToMethod);
                //var actualSum = healthSum.Select(x => GetSumAscii(string.Join("",x)).ToArray().Sum();
            //this is for damage 
                var damageNumbers = new List<string>();

                foreach (Match match in damageString)
                {
                    damageNumbers.Add(match.Value);
                }
                var sumOfDamage = damageNumbers.Select(x => decimal.Parse(x)).Sum();
                // for special symbols 

                var specSymbols = new List<string>();
                foreach (Match item in specialString)
                {
                    specSymbols.Add(item.Value);
                }
                var sumsAfterSpecialDigits = sumOfDamage;
                if (specSymbols.Count != 0)
                {
                    foreach (var item in specSymbols)
                    {
                        if (item == "*")
                        {
                            sumsAfterSpecialDigits *= 2;
                        }
                        else if (item == "/")
                        {
                            sumsAfterSpecialDigits /= 2;
                        }
                    }
                }
                Console.WriteLine($"{demon} - {actSum} health, {sumsAfterSpecialDigits:f2} damage");
            }
        }
        public static decimal GetSumAscii(string word)
        {
            var chars = word.ToCharArray();
            var sumOfDigits = 0;
            foreach (var item in chars)
            {
                sumOfDigits += (int)item;
            }
            return sumOfDigits;
        }
    }
}

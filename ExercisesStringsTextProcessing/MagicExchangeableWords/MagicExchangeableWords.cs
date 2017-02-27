using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split().ToArray();
            if (IsExchangable(input[0],input[1]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
              
        }
        private static bool IsExchangable(string a, string b)
        {
            var isEqual = true;
            var symbols = new Dictionary<char, char>();

            if (a.Length == b.Length)
            {
                for (var i = 0; i < a.Length; i++)
                {
                    var firstChar = a[i];
                    var secondChar = b[i];
                    if (!symbols.ContainsKey(firstChar))
                    {
                        symbols.Add(firstChar, secondChar);
                    }
                    else if (!symbols.ContainsValue(secondChar))
                    {
                       isEqual = false;
                    }
                }
            }
            else if (a.Length > b.Length)
            {
                for (var i = 0; i < b.Length; i++)
                {
                    var firstChar = a[i];
                    var secondChar = b[i];
                    if (!symbols.ContainsKey(firstChar))
                    {
                        symbols.Add(firstChar, secondChar);
                    }
                    else if (!symbols.ContainsValue(secondChar))
                    {
                        isEqual = false;
                    }
                }
                for (var i = b.Length; i < a.Length; i++)
                {
                    var firstChar = a[i];
                    
                    if (!symbols.ContainsKey(firstChar))
                    {
                        isEqual = true;
                    }
                    else if (!symbols.ContainsValue(firstChar))
                    {
                        isEqual = false;
                    }
                }
            }
            else if (a.Length < b.Length)
            {
                for (var i = 0; i < a.Length; i++)
                {
                    var firstChar = a[i];
                    var secondChar = b[i];
                    if (!symbols.ContainsKey(firstChar))
                    {
                        symbols.Add(firstChar, secondChar);
                    }
                    else if (!symbols.ContainsValue(secondChar))
                    {
                        isEqual = false;
                    }
                }
                for (var i = a.Length; i < b.Length; i++)
                {
                    var firstChar = b[i];

                    if (!symbols.ContainsKey(firstChar))
                    {
                        isEqual = false;
                    }
                    else if (!symbols.ContainsValue(firstChar))
                    {
                        isEqual = true;
                    }
                }
            }

            return isEqual;
        }
    }
}

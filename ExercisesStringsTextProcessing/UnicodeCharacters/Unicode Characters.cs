using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(GetUnicodeFromString(input));
        }

        private static string GetUnicodeFromString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            return sb.ToString();
        }

        
    }
}

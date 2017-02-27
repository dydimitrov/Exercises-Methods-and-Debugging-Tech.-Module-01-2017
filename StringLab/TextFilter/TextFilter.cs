using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFilter
{
    public class TextFilter
    {
        public static void Main(string[] args)
        {
            var bannedWord = Console.ReadLine().Split(new[]{ ' ',','},StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();

            for (int i = 0; i < bannedWord.Length; i++)
            {
                string replace = new string('*', bannedWord[i].Length);
                input = input.Replace(bannedWord[i], replace);
            }
            Console.WriteLine(input);
        }
    }
}

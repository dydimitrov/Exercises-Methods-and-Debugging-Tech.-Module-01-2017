using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().TrimStart().TrimEnd();
            var reg = new Regex(@"<a.*?=(""|')(\w.*?)(""|')>(\w.*?)</a>");
            var result = reg.Replace(text, @"[URL href=""$2""]$4[/URL]");
            Console.WriteLine(result);

           
        }
    }
}

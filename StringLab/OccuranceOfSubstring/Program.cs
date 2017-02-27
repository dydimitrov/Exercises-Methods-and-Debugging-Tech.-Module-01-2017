using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OccuranceOfSubstring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myString = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            int count = 0;
            int index = 0;

            while (index<myString.Length)
            {
                var found = myString.IndexOf(substring, index);
                if (found>=0)
                {
                    count++;
                    index = found+1;
                    
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
            
        }
    }
}

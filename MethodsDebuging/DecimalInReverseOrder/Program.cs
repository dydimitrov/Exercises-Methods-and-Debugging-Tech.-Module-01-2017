using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reversed = ReverseNumber(number);
            Console.WriteLine(reversed);
         }
        public static  string ReverseNumber(string number)
        {
            decimal numberDecimal = decimal.Parse(number);
            string result = "";
            for (int i = number.Length-1; i >= 0; i--)
            {
                result += number[i];
            }
            return result;
        }
    }
}

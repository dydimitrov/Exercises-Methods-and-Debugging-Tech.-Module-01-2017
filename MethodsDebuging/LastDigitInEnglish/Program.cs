using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitInEnglish
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number:");
            long n = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(GetLastDigitString(n));
        }
        public static string GetLastDigitString(long number)
        {
            string lastDigit = "";
            long lastNumber = number % 10;
            switch (lastNumber)
            {
                case 0: lastDigit = "zero"; break;
                case 1: lastDigit = "one"; break;
                case 2: lastDigit = "two"; break;
                case 3: lastDigit = "three"; ; break;
                case 4: lastDigit = "four"; ; break;
                case 5: lastDigit = "five"; ; break;
                case 6: lastDigit = "six"; ; break;
                case 7: lastDigit = "seven"; ; break;
                case 8: lastDigit = "eight"; ; break;
                case 9: lastDigit = "nine"; ; break;
            }
            return lastDigit;

        }
    }
}

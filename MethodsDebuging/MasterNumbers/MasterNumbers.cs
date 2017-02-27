using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int endNumberOfSequence = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumberOfSequence; i++)
            {
                if (IsPalindrome(i) && IsThereEvenNumber(i) && SumOfDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPalindrome(int number)
        {
            bool isPalindrome = true;
            int remainder, sum = 0, temp;
            temp = number;
            while (Convert.ToBoolean(number))
            {
                remainder = number % 10;
                number = number / 10;
                sum = sum * 10 + remainder;
            }
            if (temp == sum)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
            return isPalindrome;
        }
        public static bool SumOfDigits(int number)
        {
            bool IsDivideBySeven = true;
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 7 != 0)
            {
                IsDivideBySeven = false;
            }
            return IsDivideBySeven;
        }
        public static bool IsThereEvenNumber(int number)
        {
            bool atLeastOneEvenDigit = false;
            int remainder = 0;
            while (number != 0)
            {
                remainder = number % 10;
                if (remainder % 2 == 0)
                {
                    atLeastOneEvenDigit = true;
                    break;
                }
                number /= 10;
            }
            return atLeastOneEvenDigit;

        }
    }
}

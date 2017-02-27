using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace FactorialTrailingZones
{
    class FactorialTrailingZones
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = FindFactorial(number);
            
            Console.WriteLine(CounOfTrailingZones(factorial));
        }
        public static BigInteger FindFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }
            return factorial;
        }
        public static int CounOfTrailingZones(BigInteger factorial)
        {
            int counter = 0;
            while (factorial != 0)
            {
                BigInteger remainder = BigInteger.Remainder(factorial, 10);
                if (remainder == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                factorial = BigInteger.Divide(factorial, 10);
            }
            return counter;
            
        }
    }
}

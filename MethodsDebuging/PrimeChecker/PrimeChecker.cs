using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main(string[] args)
        {
            long inputNumer = long.Parse(Console.ReadLine());
            bool prime = IsPrime(inputNumer);
            Console.WriteLine(prime);
        }
        public static bool IsPrime(long number)
        {
            bool primeCheck = true;
            if (number == 0 || number == 1)
            {
                primeCheck = false;
            }
            else
            {
                for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if (number % divider == 0)
                    {
                        primeCheck = false;
                    }

                }
            }
            return primeCheck;

        }

    }
}
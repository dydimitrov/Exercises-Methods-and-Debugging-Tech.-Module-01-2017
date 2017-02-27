using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumberFibonacci = int.Parse(Console.ReadLine());
            CalculateFibonacci(nNumberFibonacci);
            
        }
        public static void CalculateFibonacci(int number)
        {
            int fib0 = 1;
            int fib1 = 1;
            int fibCurrent = 1;
            for (int i = 1; i < number; i++)
            {
                fib0 = fib1;
                fib1 = fibCurrent;
                fibCurrent = fib1 + fib0;   
            }

            Console.WriteLine(fibCurrent);
        }
    }
}

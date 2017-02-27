using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBaseNtoBaseTen
{
    public class ConvertFromBaseNtoBaseTen
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var baseToConvert = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);

            var numberToString = number.ToString().Reverse().ToArray();
            var sum = new BigInteger(0);
            for (int i = 0; i < numberToString.Length; i++)
            {
                var num = int.Parse(numberToString[i].ToString());
                sum += num * BigInteger.Pow(baseToConvert, i);
            }
            Console.WriteLine(sum);
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CovertBaseTenToBaseN
{
    public class CovertBaseTenToBaseN
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var baseToTransform = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);
            var result = string.Empty;

            while (number>0)
            {
                var remainder = number % baseToTransform;
                result = remainder + result;
                number /= baseToTransform;
            }
            
            Console.WriteLine(result);
        }
    }
}

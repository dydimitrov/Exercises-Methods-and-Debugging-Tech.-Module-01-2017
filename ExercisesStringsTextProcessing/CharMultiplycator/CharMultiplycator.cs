using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharMultiplycator
{
    public class CharMultiplycator
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var firstString = input[0].ToCharArray();
            var secondStrig = input[1].ToCharArray();
            var shortestArr = Math.Min(firstString.Length, secondStrig.Length);
            var longestArr=  Math.Max(firstString.Length, secondStrig.Length);
            var result = 0;

            for (int i = 0; i < shortestArr; i++)
            {
                result += (int)firstString[i] * (int)secondStrig[i];
            }
            if (firstString.Length<secondStrig.Length)
            {
                for (int i = firstString.Length; i < secondStrig.Length; i++)
                {
                    result += (int)secondStrig[i];
                }
            }
            else if (firstString.Length > secondStrig.Length)
            {
                for (int i = secondStrig.Length; i < firstString.Length; i++)
                {
                    result += (int)firstString[i];
                }
            }
            Console.WriteLine(result);

            
        }
    }
}

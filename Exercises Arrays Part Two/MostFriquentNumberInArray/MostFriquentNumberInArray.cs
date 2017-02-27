using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFriquentNumberInArray
{
     public class MostFriquentNumberInArray
    {
        public static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int mostFreqNum = 0;
            int bestLength = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = 1; j < inputArray.Length - i; j++)
                {
                    if (inputArray[i] == inputArray[i + j])
                    {
                        count++;
                    }

                    if (count > bestLength)
                    {
                        mostFreqNum = inputArray[i];
                        bestLength = count;
                    }
                }

                count = 1;
            }

            Console.WriteLine(mostFreqNum);
        }
    }
}

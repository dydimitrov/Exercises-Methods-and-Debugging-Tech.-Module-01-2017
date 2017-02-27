using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        public static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var resultLine = new List<int>();
            resultLine.Add(inputNumbers[0]);
            int startNumber = inputNumbers[0];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i]>startNumber)
                {
                    resultLine.Add(inputNumbers[i]);
                }
                else 
            }
        }
    }
}

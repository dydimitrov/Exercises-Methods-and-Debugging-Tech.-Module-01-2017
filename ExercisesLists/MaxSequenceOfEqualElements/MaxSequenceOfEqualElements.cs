using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestNum = inputNumbers[0];
            

            List<int> bestLength = new List<int>();
            List<int> currentSequence = new List<int>();
            currentSequence.Add(inputNumbers[0]);

            for (int i = 1; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] == currentSequence[0])
                {
                    currentSequence.Add(inputNumbers[i]);
                }
                else
                {
                    if (currentSequence.Count > bestLength.Count)
                    {
                        bestLength = new List<int>();
                        for (int j = 0; j < currentSequence.Count; j++)
                        {
                            bestLength.Add(currentSequence[j]);
                        }
                    }
                    currentSequence = new List<int>();
                    currentSequence.Add(inputNumbers[i]);
                }
            }
            if (currentSequence.Count > bestLength.Count)
            {
                bestLength = new List<int>();
                for (int k  = 0; k < currentSequence.Count; k++)
                {
                    bestLength.Add(currentSequence[k]);
                }
            }
            Console.WriteLine(string.Join(" ",bestLength));
        }
    }
}

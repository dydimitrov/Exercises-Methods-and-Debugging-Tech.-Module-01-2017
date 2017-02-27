using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Arrays_Part_Two
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestCurrentLength = 1;
            int bestLenght = 1;

            List<int> sequence = new List<int>();
            for (int i = 1; i <= input.Length; i++)
            {
                if (input[i] == input[i-1])
                {
                    sequence.Add(i);
                    bestCurrentLength++;
                    bestLenght = bestLenght;
                }
                else
                {
                    bestLenght = 1;
                    bestCurrentLength = 1;
                    
                }
                sequence = null;
            }
        }
    }
}

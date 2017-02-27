using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            inputNumbers.RemoveAll(x => x < 0);
            inputNumbers.Reverse();
            if (inputNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var numbers in inputNumbers)
                {

                    Console.Write(numbers + " ");
                }
            }
        }
    }
}

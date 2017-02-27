using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Reverse(input[i]);
                
            }
            List<int> result = input.Select(int.Parse).ToList();
            Console.WriteLine(result.Sum());
            
        }
        public static string Reverse(string word)
        {
            int index = word.Length - 1;
            string reversal = "";

            //for each char in word
            for (int i = index; index >= 0; index--)
            {
                reversal = reversal + (word.Substring(index, 1));
                
            }
            return reversal;
        }
    }
}

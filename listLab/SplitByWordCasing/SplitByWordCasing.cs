using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main(string[] args)
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', '\n',' ' };
            var input = Console.ReadLine().Split(separators).ToList();
            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (IsLowerCase(input[i]))
                {
                    lowerCase.Add(input[i]);
                }
                else if (IsUpperCase(input[i]))
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }
            lowerCase.RemoveAll(x => x == "");
            upperCase.RemoveAll(x => x == "");
            mixedCase.RemoveAll(x => x == "");

            Console.WriteLine("Lower-case: " + string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
        private static bool IsUpperCase(string word)
        {
            bool result = word.Equals(word.ToUpper());
            return result;
        }

        private static bool IsLowerCase(string word)
        {
            bool result = word.Equals(word.ToLower());
            return result;
        }
    }
}

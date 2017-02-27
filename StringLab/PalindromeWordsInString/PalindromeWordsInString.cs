using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeWordsInString
{
    public class PalindromeWordsInString
    {
        public static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', '?', ',','!','.' };
            var inputText = Console.ReadLine()
                            .Split(separators,StringSplitOptions.RemoveEmptyEntries)
                            .Where(w => IsPalindrome(w))
                            .OrderBy(w=>w);
            Console.WriteLine(string.Join(", ", inputText));
                
        }
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }

    }
}

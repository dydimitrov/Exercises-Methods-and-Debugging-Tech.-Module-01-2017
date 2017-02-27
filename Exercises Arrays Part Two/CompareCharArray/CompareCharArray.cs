using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    public class CompareCharArrays
    {
        public static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int n = firstArray.Length;
            int m = secondArray.Length;
            int length = Math.Min(firstArray.Length, secondArray.Length);

            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            bool equalValues = true;

            // Search which of the arrays is lexicographically earlier
            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                    break;
                }
            }
            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equalValues = false;
                }
            }
            // This is to indicate the values of the two arrays till the element of index minLength-1 are equal
            for (int i = 0; i < minLength; i++)
            {
                if (equalValues && n < m)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    break;
                }
                else if (equalValues && n > m)
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                    break;
                }
                else if (equalValues && n == m)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    break;
                }
            }

        }
    }
}


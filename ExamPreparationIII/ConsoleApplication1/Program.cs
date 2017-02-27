using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] shiftLeft(int[] arr, int shiftCount)
        {
            int[] demo = new int[arr.Length];
            int index = 0;
            for (int i = 0; i < shiftCount; i++)
            {
                demo[index] = arr[i + 1];
                index++;
            }
            return demo;
        }
        public static string[] shiftRight(string[] arr)
        {
            int[] demo = new int[arr.Length];
            int index = 0;
            for (int i = arr.length - 1; i >= 0; i--)
            {
                demo[index] = arr[(i - 1 > 0) ? i - 1 : 0];
                index++;
            }
            return demo;
        }
        public static void PartialSort<T>(this T[] array, int startIndex, int endIndex)
        {
            T[] sortedList = new T[(endIndex - startIndex) + 1];

            for (int i = startIndex; i <= endIndex; i++)
            {
                sortedList[i - startIndex] = array[i];
            }
            List<T> newList = new List<T>(sortedList);
            newList.Sort();
            sortedList = newList.ToArray();

            for (int i = 0; i < sortedList.Length; i++)
                array[i + startIndex] = sortedList[i];
        }
    }
}

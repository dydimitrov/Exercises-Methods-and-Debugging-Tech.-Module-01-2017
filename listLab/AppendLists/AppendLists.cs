using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AppendLists
{
    public class AppendLists
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
            input.RemoveAll(x => x == "");
            string tempVar = null;
            for (int i = 0; i < input.Count; i++)
            {
                tempVar += input[i] + " ";

            }

            var results = tempVar.Split(' ').ToList();
            results.RemoveAll(x => x == "");
            foreach (var item in results)
            {
                Console.Write(item + " ");
            }
        }
    }
}

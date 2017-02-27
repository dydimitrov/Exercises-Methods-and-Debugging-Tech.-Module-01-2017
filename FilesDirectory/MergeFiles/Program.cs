using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileOne = File.ReadAllLines("input1.txt").ToArray();
            var fileTwo = File.ReadAllLines("input2.txt").ToArray();

            var result = fileOne.Concat(fileTwo).OrderBy(r=>r);
            if (!File.Exists("result.txt"))
            {
                File.Create("result.txt");
            }
            File.WriteAllLines("result.txt", result);

        }
    }
}

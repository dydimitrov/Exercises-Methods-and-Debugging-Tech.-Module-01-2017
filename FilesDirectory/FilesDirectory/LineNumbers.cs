using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDirectory
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllLines("TestFile.txt");
            
            if (!File.Exists("output.txt"))
            {
                File.Create("output.txt");
            }
            var lines = new List<string>();

            for (int i = 0; i < file.Length; i++)
            {
                lines.Add($"{i+1}. "+file[i]);
            }

            File.WriteAllLines("output.txt", lines);

        }
    }
}

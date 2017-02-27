using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rootFileDir = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split('\\').ToArray();
                var root = inputLine[0];
                var fileWithExtentionAndSize = inputLine[inputLine.Length - 1].Split(';').ToArray();
                var fileNameWithExtention = fileWithExtentionAndSize[0];
                var fileSize = long.Parse(fileWithExtentionAndSize[1]);

                if (!rootFileDir.ContainsKey(root))
                {
                    rootFileDir[root] = new Dictionary<string, long>();
                }
                if (!rootFileDir[root].ContainsKey(fileNameWithExtention))
                {
                    rootFileDir[root].Add(fileNameWithExtention, fileSize);
                }
                else
                {
                    rootFileDir[root][fileNameWithExtention] = fileSize;
                }

            }

            string[] queryParams = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var queryExtension = queryParams[0];
            var queryRoot = queryParams[2];

            if (rootFileDir.ContainsKey(queryRoot))
            {

                Dictionary<string, long> foundFiles = rootFileDir[queryRoot];
                
                Dictionary<string, long> result = new Dictionary<string, long>();
                foreach (var files in foundFiles.OrderByDescending(x => x.Value).ThenBy(k => k.Key))
                {
                    if (files.Key.EndsWith(queryExtension))
                    {
                        result.Add(files.Key, files.Value);
                    }
                }
                if (result.Count!=0)
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
                
          }
           
        }
    }



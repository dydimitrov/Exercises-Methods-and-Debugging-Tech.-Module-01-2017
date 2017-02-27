using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] separators = new char[] { '-', ' ', '?', '!', '.', '\r', '\n','.',',' };
            var words = File.ReadAllText("words.txt").Split().ToList();
            var text = File.ReadAllText("text.txt").ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, int> result = new Dictionary<string, int>();
            result.Add(words[0], 0);
            result.Add(words[1], 0);
            result.Add(words[2], 0);

            for (int i = 0; i < text.Count; i++)
            {
                if (result.ContainsKey(text[i]))
                {
                    result[text[i]]++;
                }
            }
            var sortedResult = result.OrderByDescending(x => x.Value)
                                     .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                                     .ToArray();

            File.WriteAllLines("result.txt", sortedResult);

        }
    }
}

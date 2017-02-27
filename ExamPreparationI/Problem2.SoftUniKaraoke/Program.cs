using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participians = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(p => p.Trim())
                                                .ToArray();
            var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(p => p.Trim())
                                                .ToArray();
            Dictionary<string,HashSet<string>> result = new Dictionary<string, HashSet<string>>();
            
            string line = Console.ReadLine();
            while (line!="dawn")
            {
                var performance = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(p => p.Trim()).ToArray();
                var participian = performance[0];
                var song = performance[1];
                var awards = performance[2];

                if (participians.Contains(participian) && songs.Contains(song))
                {
                    if (!result.ContainsKey(participian))
                    {
                        result[participian] = new HashSet<string>();
                    }
                    
                    result[participian].Add(awards);
                }



                line = Console.ReadLine();
            }
            if (result.Values.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in result.OrderByDescending(x => x.Value.Count).ThenBy(p=>p.Key))
                {

                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                    foreach (var awards in item.Value.OrderBy(a=>a))
                    {
                        Console.WriteLine($"--{awards}");
                    }
                }
            }
        }
    }
}

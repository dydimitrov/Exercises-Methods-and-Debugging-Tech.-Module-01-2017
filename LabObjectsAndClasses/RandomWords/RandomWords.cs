using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWords
{
    public class RandomWords
    {
        public static void Main(string[] args)
        {
            var inputString = Console.ReadLine().Split();
            Random random = new Random();

            for (int i = 0; i < inputString.Length-1; i++)
            {
                var currentWord = inputString[i];
                var randomIndex = inputString[random.Next(0, inputString.Length)];
                var tempIndex = randomIndex;
                inputString[i] = tempIndex;
                randomIndex = currentWord;
            }
            foreach (var word in inputString)
            {
                Console.WriteLine(word);
            }
        }
    }
}

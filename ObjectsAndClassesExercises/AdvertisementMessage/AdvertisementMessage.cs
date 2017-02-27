using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product" };
            string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] Author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random rnd = new Random();

            var numberOfMessage = int.Parse(Console.ReadLine()); ;

            for (int i = 0; i < numberOfMessage; i++)
            {
                var phrase = Phrases[rnd.Next(0, Phrases.Length-1)];
                var events = Events[rnd.Next(0, Events.Length-1)];
                var author = Author[rnd.Next(0, Author.Length-1)];
                var cities = Cities[rnd.Next(0, Events.Length-1)];

                Console.WriteLine($"{phrase} {events} {author} – {cities}");

            }

        }
    }
}

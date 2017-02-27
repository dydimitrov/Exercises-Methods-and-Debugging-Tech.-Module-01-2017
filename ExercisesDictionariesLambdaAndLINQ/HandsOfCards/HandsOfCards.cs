using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var cardPowers = GetCardsPower();
            var cardTypes = GetCardsType();

            var cards = new Dictionary<string, HashSet<int>>();

            while (line !="JOKER")
            {
                var tokens = line.Split(':');
                var name = tokens[0];
                var playerCards = tokens[1].Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length-1);
                    var sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    cards[name].Add(sum);
                }
                line =Console.ReadLine();
            }
            foreach (var item in cards)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Sum()}");
            }
        }
        private static Dictionary<string, int> GetCardsPower()
        {
            var powers = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }
            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;
            return powers;
        }
        private static Dictionary<string, int> GetCardsType()
        {
            var cardsType = new Dictionary<string, int>();

            cardsType["S"] = 4;
            cardsType["H"] = 3;
            cardsType["D"] = 2;
            cardsType["C"] = 1;
            return cardsType;
        }

    }
}

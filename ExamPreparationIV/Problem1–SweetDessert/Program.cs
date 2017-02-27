using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {

            var amountOfCash = double.Parse(Console.ReadLine());
            var numberOfGuests = long.Parse(Console.ReadLine());

            var priceOfBannana = double.Parse(Console.ReadLine());
            var priceOfEggs = double.Parse(Console.ReadLine());
            var priceOfBerries = double.Parse(Console.ReadLine());

            var receipForSixPeople = 2 * priceOfBannana + 4 * priceOfEggs + (0.2 * priceOfBerries);
            long numberOfDozens = 0;
            if (numberOfGuests%6==0)
            {
                numberOfDozens = numberOfGuests / 6;
            }
            else
            {
                numberOfDozens = numberOfGuests / 6 + 1;
            }

            var totalSpentMoney = numberOfDozens * receipForSixPeople;

            if (totalSpentMoney>amountOfCash)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(totalSpentMoney-amountOfCash):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalSpentMoney:f2}lv.");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfOrders = int.Parse(Console.ReadLine());
            var total = 0m;    

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePreCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsuleCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var currentPrice = daysInMonth * capsuleCount * pricePreCapsule;
                total+= currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
            
        }
        
    }
}

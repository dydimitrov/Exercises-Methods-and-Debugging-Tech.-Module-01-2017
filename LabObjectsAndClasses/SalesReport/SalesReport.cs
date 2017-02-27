using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var resultReport = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentLine = Console.ReadLine().Split().ToArray();
                Sales currentSale = new Sales
                {
                    Town = currentLine[0],
                    Product = currentLine[1],
                    Price = decimal.Parse(currentLine[2]),
                    Quantity = decimal.Parse(currentLine[3])
                };
                if (!resultReport.ContainsKey(currentSale.Town))
                {
                    resultReport.Add(currentSale.Town, currentSale.EarnMoney);
                }
                else
                {
                    resultReport[currentSale.Town] += currentSale.EarnMoney;
                }
            }
            foreach (var item in resultReport)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }

}

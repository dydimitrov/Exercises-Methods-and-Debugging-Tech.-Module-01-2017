using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CenterPoint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            FindClosePoint(x1, y1, x2, y2);
            
        }
        public static void FindClosePoint(double x1, double y1,double x2, double y2)
        {
            double distanceFirstPoint = Math.Sqrt((x1 - 0)* (x1 - 0) + (y1 - 0)* (y1 - 0));
            double distanceSecondPoint = Math.Sqrt((x2 - 0)*(x2 - 0) + (y2 - 0)* (y2 - 0));
            if (distanceFirstPoint<distanceSecondPoint || distanceFirstPoint==distanceSecondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}

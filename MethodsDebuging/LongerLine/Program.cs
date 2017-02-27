using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x= double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x0 = double.Parse(Console.ReadLine());
            double y0 = double.Parse(Console.ReadLine());

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distanceFirstLine = FindDistanceLine(x, y, x0, y0);
            double distanceSecondLine = FindDistanceLine(x1, y1, x2, y2);

            if (distanceFirstLine>distanceSecondLine)
            {
                FindClosePoint(x, y, x0, y0);
            }
            else
            {
                FindClosePoint(x1, y1, x2, y2);
            }
        }
        public static double FindDistanceLine(double x1, double y1, double x2, double y2)
        {
            double distanceFirstPoint = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distanceFirstPoint;
            
        }
        public static void FindClosePoint(double x1, double y1, double x2, double y2)
        {
            double distanceFirstPoint = Math.Sqrt((x1 - 0) * (x1 - 0) + (y1 - 0) * (y1 - 0));
            double distanceSecondPoint = Math.Sqrt((x2 - 0) * (x2 - 0) + (y2 - 0) * (y2 - 0));
            if (distanceFirstPoint < distanceSecondPoint || distanceFirstPoint == distanceSecondPoint)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
